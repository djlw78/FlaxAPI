////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using FlaxEditor.SceneGraph.Actors;

namespace FlaxEditor.SceneGraph.GUI
{
    /// <summary>
    /// A <see cref="ActorTreeNode"/> custom implementation for <see cref="SceneNode"/>.
    /// </summary>
    /// <seealso cref="FlaxEditor.SceneGraph.GUI.ActorTreeNode" />
    public sealed class SceneTreeNode : ActorTreeNode
    {
        /// <inheritdoc />
        public override void UpdateText()
        {
            base.UpdateText();

            // Append star character to modified scenes
            if (ActorNode is SceneNode node && node.IsEdited)
                Text += "*";
        }
    }
}