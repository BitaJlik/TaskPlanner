using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TkachV.TaskPlanner.ConsoleRunner.Models.Enums;

namespace TkachV.TaskPlanner.ConsoleRunner.Models
{
     internal class WorkItem 
    {
        private static readonly Random random = new Random((int)DateTime.Now.Ticks);

        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public String Tile { get; set; }
        public String Description { get; set; }
        
        bool IsCompleted { get; set; }

        public WorkItem()
        {
            CreationDate = (DateTime.Now);
            DueDate = CreationDate.AddDays(random.Next(12));
            Array valuesP = Enum.GetValues(typeof(Priority));
            Priority = (Priority)valuesP.GetValue(random.Next(valuesP.Length));
            Array valuesC = Enum.GetValues(typeof(Complexity));
            Complexity = (Complexity)valuesC.GetValue(random.Next(valuesC.Length));
            Tile = $"Tile {random.Next(256)}";
            Description = $"Desc {random.Next(256)}";

        }

        public override string ToString()
        {
            return ($"Do: {Tile,-10} due: {DueDate.ToString("dd.MM.yyyy",CultureInfo.InvariantCulture)} {Priority,-10} priority");
        }

 
    }
}
