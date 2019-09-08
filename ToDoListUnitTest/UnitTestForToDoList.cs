using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace ToDoListUnitTest
{
    [TestClass]
    public class UnitTestForToDoList
    {
        TodoList todoList;

        [TestInitialize]
        public void Setup()
        {
            todoList = new TodoList();
        }

        [DataTestMethod]
        [DataRow("task1", "task1", DisplayName = "AddAndReturnTask1")]
        [DataRow("task2", "task2", DisplayName = "AddAndReturnTask2")]
        [DataRow("task3", "task3", DisplayName = "AddAndReturnTask3")]
        public void AddTask_WhenTaskIsAdded_GetSingleMatchingTask(string description, string expectedDescription)
        {
            Task task = new Task(description);

            todoList.addTask(task);
            var actualDescription = todoList.getTask(description).getDescription();

            Assert.AreEqual(todoList.getAllTasks().Count, 1);
            Assert.AreEqual(actualDescription, expectedDescription);
        }

        [TestMethod]
        public void CompleteTask_WhenCalledOnceForTwoTasks_ReturnOneCompleteOneUncomplete()
        {
            Task task1 = new Task("1");            
            Task task2 = new Task("2");            

            todoList.addTask(task1);
            todoList.addTask(task2);

            todoList.completeTask("1");
            var completedTasks = todoList.getCompletedTasks();

            Assert.AreEqual(completedTasks.Count, 1);
            Assert.AreEqual(task1.isComplete(), true);
            Assert.AreEqual(task2.isComplete(), false);
        }


    }
}
