using System;
using System.Collections.Generic;

namespace Daily.Models
{
    public class TaskToday
    {
        public string CurrentDay { get; set; }
        public List<SingleTask> Tasks { get; set; }

        public TaskToday()
        {
            CurrentDay = DateTime.Now.ToString("dd.MM");

            Tasks = new List<SingleTask>();

            for (int i = 1; i <= 30; i++)
            {
                Tasks.Add(new SingleTask(i, "Написать ежедневник Написать ежедневник Написать ежедневник Написать ежедневник Написать ежедневник Написать ежедневник"));
            }
        }
    }

    public class SingleTask
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Task { get; set; }

        public SingleTask(int id, string task)
        {
            Id = id;
            Time = DateTime.Now.ToString("mm:ff");
            Task = task;
        }
    }
}
