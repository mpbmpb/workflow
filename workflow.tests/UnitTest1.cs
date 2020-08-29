using System;
using Xunit;
using FluentAssertions;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace workflow.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Workflow_Add_adds_IExecutable_to_taskList()
        {
            var work = new Workflow();
            var task = new SplineReticulator("curvilinear");

            work.Add(task);
            var result = work.GetTaskList();

            result.Should().Contain(task);
        }

        [Fact]
        public void Workflow_Add_adds_multiple_IExecutables_to_taskList()
        {
            var work = new Workflow();
            var task1 = new SplineReticulator("curvilinear");
            var task2 = new VirtualAudioMode("Silent");

            work.Add(task1);
            work.Add(task2);
            var result = work.GetTaskList();

            result[0].Should().Be(task1);
            result[1].Should().Be(task2);
        }

        [Theory]
        [InlineData("curvilinear", "silent")]
        [InlineData("rectilinear", "invisible")]
        public async Task WorkflowEngine_Run_runs_all_tasks_with_correct_parameters(string param1, string param2)
        {
            var work = new Workflow();
            work.Add(new SplineReticulator(param1));
            work.Add(new VirtualAudioMode(param2));

            var result = await GetOutputFor(WorkflowEngine.Run, work);

            result.Should().ContainAll($"using {param1} covariant basis",
                $"Virtual audio system succesfully set to {param2} mode");
        }

        [Fact]
        public async Task Workflow_LogContents_logs_all_tasks()
        {
            var work = new Workflow();
            work.Add(new SplineReticulator("curvilinear"));
            work.Add(new VirtualAudioMode("Silent"));
            work.Add(new VirtualAudioSystem());

            var result = await GetOutputFor(work.LogContents);

            result.Should().ContainAll("SplineReticulator(curvilinear)",
                "VirtualAudioMode(Silent)",
                "VirtualAudioSystem()");
        }

        [Fact]
        public void Workflow_Remove_removes_task_from_taskList()
        {
            var work = new Workflow();
            var task1 = new SplineReticulator("curvilinear");
            work.Add(task1);
            var task2 = new VirtualAudioMode("Silent");
            work.Add(task2);
            work.Remove(task2);

            var result = work.GetTaskList();

            result.Should().NotContain(task2);
            result.Should().Contain(task1);
        }

        [Fact]
        public void Workflow_Remove_throws_exception_if_task_not_in_taskList()
        {
            var work = new Workflow();
            var task1 = new SplineReticulator("curvilinear");
            work.Add(task1);
            var task2 = new VirtualAudioMode("Silent");

            Exception result = new Exception();
            try
            {
                work.Remove(task2);
            }
            catch (Exception ex)
            {
                result = ex;
            }

            result.Should().BeOfType<NullReferenceException>();
            result.Message.Should().Contain("Task is not in taskList");
        }

        [Fact]
        public void SplineReticulator_throws_exception_if_coordinateType_is_NullOrEmpty()
        {
            Exception result1 = new Exception();
            try
            {
                var task = new SplineReticulator(null);
            }
            catch (Exception ex)
            {
                result1 = ex;
            }
            Exception result2 = new Exception();
            try
            {
                var task = new SplineReticulator("");
            }
            catch (Exception ex)
            {
                result2 = ex;
            }

            result1.Should().BeOfType<NullReferenceException>();
            result1.Message.Should().Contain("coordinateType must be " +
                    "defined for splines to be reticulated.");
            result2.Should().BeOfType<NullReferenceException>();
            result2.Message.Should().Contain("coordinateType must be " +
                    "defined for splines to be reticulated.");
        }
        
        [Fact]
        public void VirtualAudioMode_throws_exception_if_mode_is_NullOrEmpty()
        {
            Exception result1 = new Exception();
            try
            {
                var task = new VirtualAudioMode(null);
            }
            catch (Exception ex)
            {
                result1 = ex;
            }
            Exception result2 = new Exception();
            try
            {
                var task = new VirtualAudioMode("");
            }
            catch (Exception ex)
            {
                result2 = ex;
            }

            result1.Should().BeOfType<NullReferenceException>();
            result1.Message.Should().Contain("Virtual audio mode must be defined");
            result2.Should().BeOfType<NullReferenceException>();
            result2.Message.Should().Contain("Virtual audio mode must be defined");
        }

        private static Task<string> GetOutputFor(Action<Workflow> method, Workflow work)
        {
            string expected;
            using (var stream = new MemoryStream())
            {
                using (var logger = new StreamWriter(stream))
                {
                    Console.SetOut(logger);
                    method.Invoke(work);
                }
                expected = Encoding.UTF8.GetString(stream.ToArray());
            }
            return Task.FromResult(expected);
        }
        
        private static Task<string> GetOutputFor(Action method)
        {
            string expected;
            using (var stream = new MemoryStream())
            {
                using (var logger = new StreamWriter(stream))
                {
                    Console.SetOut(logger);
                    method.Invoke();
                }
                expected = Encoding.UTF8.GetString(stream.ToArray());
            }
            return Task.FromResult(expected);
        }

    }
}
