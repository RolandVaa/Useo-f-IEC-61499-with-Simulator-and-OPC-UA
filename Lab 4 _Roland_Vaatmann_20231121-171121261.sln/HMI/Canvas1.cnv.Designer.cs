/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 23/09/2021
 * Time: 1:29 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HMI = new HMI.Main.Symbols.ControlHMI.sDefault();
			// 
			// HMI
			// 
			this.HMI.BeginInit();
			this.HMI.AngleIgnore = false;
			this.HMI.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 120D, 40D);
			this.HMI.Name = "HMI";
			this.HMI.SecurityToken = ((uint)(4294967295u));
			this.HMI.TagName = "C5183860C76B84E";
			this.HMI.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(456D)), ((float)(436D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HMI});
			this.Size = new System.Drawing.Size(456, 436);

		}
		private HMI.Main.Symbols.ControlHMI.sDefault HMI;
		#endregion
	}
}
