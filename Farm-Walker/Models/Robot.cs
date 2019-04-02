using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Walker.Models
{
    public class Robot
    {

        public Point Position { get; set; }
        public int RightTurn { get; set; }


        public Robot(Point Position)
        {
            this.Position = Position;
            RightTurn = 0;
        }

        public List<Point> MoveRight(int steps)
        {
            RightTurn++;
            List<Point> points = new List<Point>();
            for (int i = 0; i < steps; i++)
            {
                points.Add(new Point(Position.x + 1, Position.y));
                this.Position = new Point(Position.x + 1, Position.y);

            }
            return points;
        }
        public List<Point> MoveLeft(int steps)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < steps; i++)
            {
                points.Add(new Point(Position.x - 1, Position.y));
                this.Position = new Point(Position.x - 1, Position.y);

            }
            return points;
        }
        public List<Point> MoveUp(int steps)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < steps; i++)
            {
                points.Add(new Point(Position.x, Position.y + 1));
                this.Position = new Point(Position.x, Position.y + 1);
            }
            return points;
        }

        public List<Point> MoveDown(int steps)
        {
            
            List<Point> points = new List<Point>();
            for (int i = 0; i < steps; i++)
            {
                points.Add(new Point(Position.x, Position.y - 1));
                this.Position = new Point(Position.x, Position.y - 1);
            }
            return points;

                    }

    }
}
