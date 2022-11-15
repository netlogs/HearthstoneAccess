using Hearthstone_Deck_Tracker;
using CoreAPI = Hearthstone_Deck_Tracker.API.Core;
using DrawingPoint = System.Drawing.Point;
using System;
using System.Windows.Controls;
using System.ComponentModel;
using Hearthstone_Deck_Tracker.Windows;

namespace HearthstoneAccess.Models
{
    public class Position : INotifyPropertyChanged
    {

        public static User32.MouseInput Input;
        public Canvas OverlayCanvas => CoreAPI.OverlayCanvas;
        public OverlayWindow OverlayWindow => CoreAPI.OverlayWindow;
        public Position()
        {

            CursorPoint = User32.GetMousePos();
            CursorInOverlayPoint = ComputedOverlayPoint(User32.GetMousePos());

            if (Input == null)
            {
                Input = new User32.MouseInput();
            }

            Input.MouseMoved += (object sender, EventArgs eventArgs) =>
            {
                CursorPoint = User32.GetMousePos();
                CursorInOverlayPoint = ComputedOverlayPoint(User32.GetMousePos());
            };
        }


        private static DrawingPoint _cusorPoint;
        public DrawingPoint CursorPoint
        {
            get
            {
                return _cusorPoint;
            }

            set
            {
                _cusorPoint = value;
                RaisePropetyChanged("CursorPoint");
            }
        }

        private static DrawingPoint _cursorInOverlayPoint;
        public DrawingPoint CursorInOverlayPoint
        {
            get
            {
                return _cursorInOverlayPoint;
            }

            set
            {
                _cursorInOverlayPoint = value;
                RaisePropetyChanged("CursorInOverlayPoint");
            }
        }

        public DrawingPoint ComputedOverlayPoint(DrawingPoint drawingPoint)
        {

            if (CoreAPI.OverlayWindow.Left is double.NaN || CoreAPI.OverlayWindow.Top is double.NaN)
            {
                return new DrawingPoint(0, 0);
            }
            double x = Math.Max(0, Math.Min(drawingPoint.X - CoreAPI.OverlayWindow.Left, CoreAPI.OverlayWindow.Width));
            double y = Math.Max(0, Math.Min(drawingPoint.Y - CoreAPI.OverlayWindow.Top, CoreAPI.OverlayWindow.Height));
            return new DrawingPoint((int)x, (int)y);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropetyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
