////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.GUI
{
    /// <summary>
    /// Status strip GUI control.
    /// </summary>
    /// <seealso cref="FlaxEngine.GUI.ContainerControl" />
    public class StatusBar : ContainerControl
    {
        /// <summary>
        /// The default height.
        /// </summary>
        public const int DefaultHeight = 22;

        /// <summary>
        /// Gets or sets the color of the status strip.
        /// </summary>
        /// <value>
        /// The color of the status strip.
        /// </value>
        public Color StatusColor
        {
            get => BackgroundColor;
            set => BackgroundColor = value;
        }

        /// <summary>
        /// Gets or sets the status text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusBar"/> class.
        /// </summary>
        public StatusBar()
            : base(0, 0, 100, DefaultHeight)
        {
            CanFocus = false;
            DockStyle = DockStyle.Bottom;
        }

        /// <inheritdoc />
        public override void Draw()
        {
            base.Draw();

            var style = Style.Current;
            var window = ParentWindow;

            // Draw size grip
            if (window != null && !window.IsMaximized)
                Render2D.DrawSprite(style.StatusBarSizeGrip, new Rectangle(Width - 12, 10, 12, 12));
            
            // Draw status text
            Render2D.DrawText(style.FontSmall, Text, new Rectangle(4, 0, Width - 20, Height), style.Foreground, TextAlignment.Near, TextAlignment.Center);
        }
    }
}
