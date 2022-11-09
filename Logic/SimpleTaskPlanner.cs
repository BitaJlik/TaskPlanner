using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TkachV.TaskPlanner.ConsoleRunner.Models;

namespace TkachV.TaskPlanner.ConsoleRunner.Logic
{
    internal class SimpleTaskPlanner
    {

        public WorkItem[] CreatePlan(WorkItem[] items)
        {
            List<WorkItem> list = items.ToList<WorkItem>();
            List<WorkItem> list1 = items.ToList<WorkItem>();
            list.Sort(CompareWorkItems);
            
            return list.ToArray();
        }

        public static int CompareWorkItems(WorkItem firstItem, WorkItem secondItem)
        {
            int cPriority = secondItem.Priority.CompareTo(firstItem.Priority);
            int cDueDate = firstItem.DueDate.CompareTo(secondItem.DueDate);
            int cTile = firstItem.Tile.CompareTo(secondItem.Tile);
            if (cPriority == 0)
            {
                if (cDueDate == 0)
                {
                    return cTile;
                }
                else return cDueDate;
            }
            else return cPriority;
        }
    }
}
