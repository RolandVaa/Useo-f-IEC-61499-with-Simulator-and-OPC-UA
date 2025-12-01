/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 23/09/2021
 * Time: 1:11 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ControlHMI
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ProcessStatus = new System.HMI.Symbols.Base.TextBox<string>();
			this.START = new System.HMI.Symbols.Base.SwitchButton();
			this.RESET = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			// 
			// ProcessStatus
			// 
			this.ProcessStatus.BeginInit();
			this.ProcessStatus.AngleIgnore = false;
			this.ProcessStatus.DesignTransformation = new NxtControl.Drawing.Matrix(1.2266666666666666D, 0D, 0D, 1.6D, 24D, 32D);
			this.ProcessStatus.IsOnlyInput = true;
			this.ProcessStatus.MaximumTag = null;
			this.ProcessStatus.MinimumTag = null;
			this.ProcessStatus.Name = "ProcessStatus";
			this.ProcessStatus.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ProcessStatus.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.ProcessStatus.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ProcessStatus.TagName = "ProcessStatus";
			this.ProcessStatus.Value = null;
			this.ProcessStatus.EndInit();
			// 
			// START
			// 
			this.START.BeginInit();
			this.START.AngleIgnore = false;
			this.START.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 136D, 80D);
			this.START.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.START.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.START.Name = "START";
			this.START.TagName = "START";
			this.START.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.START.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.START.Value = false;
			this.START.EndInit();
			// 
			// RESET
			// 
			this.RESET.BeginInit();
			this.RESET.AngleIgnore = false;
			this.RESET.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 136D, 128D);
			this.RESET.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.RESET.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.RESET.Name = "RESET";
			this.RESET.TagName = "RESET";
			this.RESET.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.RESET.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.RESET.Value = false;
			this.RESET.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "START PROCESS";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 136D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "RESET PROCESS";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(56D, 8D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "PROCESS STATUS";
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ProcessStatus,
			this.START,
			this.RESET,
			this.freeText1,
			this.freeText2,
			this.freeText3});
			this.SymbolSize = new System.Drawing.Size(264, 200);

		}
		private System.HMI.Symbols.Base.TextBox<string> ProcessStatus;
		private System.HMI.Symbols.Base.SwitchButton START;
		private System.HMI.Symbols.Base.SwitchButton RESET;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		#endregion
	}
}
