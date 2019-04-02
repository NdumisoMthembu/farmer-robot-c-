using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Walker.Models
{
    public class Commander
    {

        public List<string> Commands { get; set; }
        public Robot robot { get; set; }
        List<Point> paths;

        public Commander(List<string> Commands)
        {
            this.Commands = Commands;
            paths = new List<Point>();
            robot = new Robot(new Point(0, 0));
            // paths.Add(robot.Position);
        }

        public int Run()
        {
            foreach (string cmd in this.Commands)
            {
                string direction = cmd.Substring(0, 1);
                int steps = 0;
                if (!Int32.TryParse(cmd.Substring(1), out steps))
                    steps = -1;

                switch (direction.ToLower())
                {
                    case "n":
                        paths.AddRange(robot.MoveUp(steps));
                        break;
                    case "s":
                        paths.AddRange(robot.MoveDown(steps));
                        break;
                    case "e":
                        paths.AddRange(robot.MoveRight(steps));
                        break;
                    case "w":
                        paths.AddRange(robot.MoveLeft(steps));
                        break;
                    default: break;
                }
            }

            return CalculateResult();
        }

        private int  CalculateResult()
        {
            Hashtable validPoints = new Hashtable();
            foreach (Point p in paths)
            {
                string key = String.Format("{0}{1}", p.x, p.y);
                if (!validPoints.ContainsKey(key))
                {
                    validPoints.Add(key, p);
                }
            }

            Console.WriteLine(String.Format("Unique squares a robot visited: {0}", validPoints.Count));
            Console.WriteLine(String.Format("Right hand turns robot made: {0}", this.robot.RightTurn));
            return validPoints.Count;
        }

    }
}
