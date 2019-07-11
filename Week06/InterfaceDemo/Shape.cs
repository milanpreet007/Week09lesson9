using System.Drawing;
using System.IO;
namespace InterfaceDemo
{
    interface IDrawable { void Draw(Graphics g); }
    interface IWriteable { void Write( TextWriter writer); }
    class Shape
    {
    }
    abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }
        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            Color = color;
            Filled = filled;
            Rectangle = rectangle;

        }
        public abstract void Draw(Graphics g);
    }
       class DrawableRectangle : Parent,IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            :base (color,filled,rectangle)
        { }
        public override void Draw(Graphics g)
        {
            if(Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);

            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }        
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color.ToKnownColor()} rectangle {(Filled ? "filled" : "border")}");
        }
    }
    class DrawableEllipse : Parent,IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle) :base (color,filled,rectangle)
        { }
        public override void Draw(Graphics g)
        {
            if(Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }
    }
    class DrawableLine : IDrawable,IWriteable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point End { get; }
        public DrawableLine(Color color, Point start, Point end)
        {
            Color = color;
            Start = start;
            End = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawLine(pen,Start,End);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color} {Start} {End}");
        }
    }
    class DrawableBezier : IDrawable,IWriteable
    {
        protected Color color { get; }
        protected Point curveStart { get; }
        protected Point controlFirst { get; }
        protected Point controlSecond{ get; }
        protected Point curveEnd { get; }
        public DrawableBezier(Color color, Point start, Point end, Point first, Point second)
        {
            this.color = color;
            curveStart = start;
            controlFirst = first;
            controlSecond = second;
            curveEnd = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawBezier(pen, curveStart, controlFirst, controlSecond, curveEnd);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{color} {curveStart} {curveEnd}{controlFirst}{controlSecond}");
        }
    }
     class DrawableArc : Parent,IWriteable
    {
        protected float start;
        protected float end;
        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) :base (color,filled,rectangle)
        {
            this.start = start;
            this.end = end;
        }
        override public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color);
            g.FillPie(brush, Rectangle, start, end);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{start} {end} ");
        }
    }
    

}
