﻿namespace TodoApi.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }


    }
}
