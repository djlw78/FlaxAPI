////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

namespace FlaxEditor.CustomEditors.Elements
{
	/// <summary>
	/// The floating point value editor element.
	/// </summary>
	public interface IFloatValueEditor
	{
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		float Value { get; set; }

		/// <summary>
		/// Gets a value indicating whether user is using a slider.
		/// </summary>
		bool IsSliding { get; }
	}
}
