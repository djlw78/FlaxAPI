////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.Surface.Elements
{
    /// <summary>
    /// Text box input element.
    /// </summary>
    /// <seealso cref="TextBox" />
    /// <seealso cref="ISurfaceNodeElement" />
    public sealed class TextBoxView : TextBox, ISurfaceNodeElement
    {
        /// <inheritdoc />
        public SurfaceNode ParentNode { get; }

        /// <inheritdoc />
        public NodeElementArchetype Archetype { get; }

        /// <summary>
        /// Gets the surface.
        /// </summary>
        public VisjectSurface Surface => ParentNode.Surface;

        /// <inheritdoc />
        public TextBoxView(SurfaceNode parentNode, NodeElementArchetype archetype)
            : base(archetype.BoxID == 1, archetype.Position.X, archetype.Position.Y, archetype.Size.X)
        {
            ParentNode = parentNode;
            Archetype = archetype;

            Size = archetype.Size;
            if (archetype.ValueIndex >= 0)
            {
                Text = (string)parentNode.Values[archetype.ValueIndex];
                EditEnd += () =>
                           {
                               ParentNode.Values[Archetype.ValueIndex] = Text;
                               Surface.MarkAsEdited();
                           };
            }
        }

        /// <inheritdoc />
        public override void Draw()
        {
            base.Draw();

            // Draw border
            if (!IsFocused)
                Render2D.DrawRectangle(new Rectangle(Vector2.Zero, Size), Style.Current.BorderNormal);
        }
    }
}
