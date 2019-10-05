using Infragistics.Win.IGControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasozi_s_Text_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region EventHandlers
        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "MiniBarSave":
                    {
                        Save();
                        break;
                    }
                case "MiniBarUndo":    // ButtonTool
                                       // Place code here
                    break;

                case "MiniBarRedo":    // ButtonTool
                                       // Place code here
                    break;

                case "MiniBarNew":    // ButtonTool
                                      // Place code here
                    break;

                case "MiniBarClose":    // ButtonTool
                                        // Place code here
                    break;

                case "PasteButton":    // ButtonTool
                                       // Place code here
                    break;

                case "CutButton":    // ButtonTool
                                     // Place code here
                    break;

                case "CopyButton":    // ButtonTool
                                      // Place code here
                    break;

                case "FontButton":    // ButtonTool
                                      // Place code here
                    break;

                case "FontType":    // TextBoxTool
                                    // Place code here
                    break;

                case "FontSize":    // TextBoxTool
                                    // Place code here
                    break;

                case "BoldButton":    // ButtonTool
                                      // Place code here
                    break;

                case "italicButton":    // ButtonTool
                                        // Place code here
                    break;

                case "UnderlineButton":    // ButtonTool
                                           // Place code here
                    break;

                case "Strikethrough":    // ButtonTool
                                         // Place code here
                    break;

                case "underline":    // ButtonTool
                                     // Place code here
                    break;

                case "strikeout":    // ButtonTool
                                     // Place code here
                    break;

                case "superscriptButton":    // ButtonTool
                                             // Place code here
                    break;

                case "SubscriptButton":    // ButtonTool
                                           // Place code here
                    break;

                case "IncreaseFontButton":    // ButtonTool
                                              // Place code here
                    break;

                case "ReduceFontButton":    // ButtonTool
                                            // Place code here
                    break;

                case "FontColor":    // ButtonTool
                                     // Place code here
                    break;

                case "LeftIndentButton":    // ButtonTool
                                            // Place code here
                    break;

                case "RightIndentButton":    // ButtonTool
                                             // Place code here
                    break;

                case "BulletButton":    // ButtonTool
                                        // Place code here
                    break;

                case "Left":    // ButtonTool
                                // Place code here
                    break;

                case "CenterButton":    // ButtonTool
                                        // Place code here
                    break;

                case "RightButton":    // ButtonTool
                                       // Place code here
                    break;

                case "Office7Button":    // ButtonTool
                                         // Place code here
                    break;

                case "Office10Button":    // ButtonTool
                                          // Place code here
                    break;

                case "OfficexpButton":    // ButtonTool
                                          // Place code here
                    break;

                case "Office13Button":    // ButtonTool
                                          // Place code here
                    break;

                case "FindButton":    // ButtonTool
                                      // Place code here
                    break;

                case "ReplaceButton":    // ButtonTool
                                         // Place code here
                    break;

                case "SelectAllButton":    // ButtonTool
                                           // Place code here
                    break;

                case "UpperCaseButton":    // ButtonTool
                                           // Place code here
                    break;

                case "LowerCaseButton":    // ButtonTool
                                           // Place code here
                    break;

                case "NewButtonBV":    // PopupMenuTool
                                       // Place code here
                    break;

                case "OpenButtonBV":    // PopupMenuTool
                                        // Place code here
                    break;

                case "SaveButtonBV":    // PopupMenuTool
                                        // Place code here
                    break;

                case "Save AsButtonBV":    // PopupMenuTool
                                           // Place code here
                    break;

                case "CloseButtonBV":    // PopupMenuTool
                                         // Place code here
                    break;

                case "ExitButtonBV":    // PopupMenuTool
                                        // Place code here
                    break;

                case "Date_Time":    // ButtonTool
                                     // Place code here
                    break;

                case "DTButton":    // ButtonTool
                                    // Place code here
                    break;

                case "Image":    // ButtonTool
                                 // Place code here
                    break;

                case "NewDocumentInsertTab":    // ButtonTool
                                                // Place code here
                    break;

                case "NewDoc13":    // PopupMenuTool
                                    // Place code here
                    break;

                case "OpenDoc13":    // PopupMenuTool
                                     // Place code here
                    break;

                case "SaveDoc13":    // PopupMenuTool
                                     // Place code here
                    break;

                case "Save AsDoc13":    // PopupMenuTool
                                        // Place code here
                    break;

                case "CloseDoc13":    // PopupMenuTool
                                      // Place code here
                    break;

                case "ExitDoc13":    // ButtonTool
                                     // Place code here
                    break;

                case "Create New Document(13)":    // LabelTool
                                                   // Place code here
                    break;

                case "New13":    // ButtonTool
                                 // Place code here
                    break;

                case "Open an existing Document(13)":    // LabelTool
                                                         // Place code here
                    break;

                case "Open13":    // ButtonTool
                                  // Place code here
                    break;

                case "Save the current Document(13)":    // LabelTool
                                                         // Place code here
                    break;

                case "Re-save the current document(13)":    // LabelTool
                                                            // Place code here
                    break;

                case "Close all open documents(13)":    // LabelTool
                                                        // Place code here
                    break;

                case "Close(13)":    // ButtonTool
                                     // Place code here
                    break;

                case "VStudioButton":    // ButtonTool
                                         // Place code here
                    break;

            }


        }

        #endregion

        #region Properties
        private RichTextBox GetCurrentDocument => (RichTextBox)tabControl1.SelectedTab.Controls["Body"];
        #endregion

        #region HelperMethods
        
        #region Tabs 
        private void AddTab()
        {
            RichTextBox Body = new RichTextBox();
            Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            Body.Size = new System.Drawing.Size(658, 531);
            Body.Location = new System.Drawing.Point(165, 3);
            Body.TabIndex = 0;
            Body.AcceptsTab = true;
            Body.Name = "Body";
            Spelling.SetSpellCheckerSettings(Body, new Infragistics.Win.UltraWinSpellChecker.SpellCheckerSettings(true));
            Body.AutoWordSelection = true;
            Body.EnableAutoDragDrop = true;
            Body.MouseDown += new System.Windows.Forms.MouseEventHandler(kasozi);
            menu.Style = MenuStyle.Office2013;
            Body.ContextMenu = menu;
            

            TabPage NewPage = new TabPage();
            NewPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            NewPage.ForeColor = System.Drawing.SystemColors.Highlight;
            NewPage.Location = new System.Drawing.Point(4, 32);
            NewPage.Padding = new System.Windows.Forms.Padding(3);
            NewPage.Size = new System.Drawing.Size(1023, 547);
            NewPage.TabIndex = 0;
            TabCount += 1;
            string DocumentText = "Document " + TabCount;
            NewPage.Name = DocumentText;
            NewPage.Text = DocumentText;
            NewPage.Controls.Add(Body);
            tabControl1.TabPages.Add(NewPage);
            toolStripStatusLabel1.Text = "Number of Tabs : " + TabCount.ToString();

        }
        private void RemoveTab()
        {
            if (tabControl1.TabPages.Count == 1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                TabCount -= 1;
                toolStripStatusLabel1.Text = "Number of Tabs : " + TabCount.ToString();
                disable();

            }
            else if (tabControl1.TabPages.Count >= 1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                TabCount -= 1;
                toolStripStatusLabel1.Text = "Number of Tabs : " + TabCount.ToString();
            }
            else
            {

                MessageBox.Show("You have no documents to close", "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

        }

        private void disable()
        {
        }
        private void RemoveAllTabs()
        {

            foreach (TabPage Page in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(Page);
            }
            // AddTab();
        }
        private void RemoveAllTabsButThis()
        {
            foreach (TabPage Page in tabControl1.TabPages)
            {
                if (Page.Name != tabControl1.SelectedTab.Name)
                {
                    tabControl1.TabPages.Remove(Page);
                }
            }

        }
        #endregion

        #region SaveAndOpen 
        private void Save()
        {
            if (tabControl1.TabPages.Count > 0)
            {
                // saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog1.Filter = "RTF|*.rtf";
                saveFileDialog1.Title = "Save";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (saveFileDialog1.FileName.Length > 0)
                    {
                        GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        tabControl1.SelectedTab.Text = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                        tabControl1.SelectedTab.Name = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                        Text = "Kasozi's Text Editor " + "(" + tabControl1.SelectedTab.Name + ")";
                    }
                    else
                    {
                        MessageBox.Show("Filename can't be empty", "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                _ = MessageBox.Show("You have no open documents", "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); ;


        }
        private void SaveAs()
        {
            //  saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
            saveFileDialog1.Title = "Save As";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    tabControl1.SelectedTab.Name = saveFileDialog1.FileName;
                    tabControl1.SelectedTab.Text = saveFileDialog1.FileName;
                    Text = tabControl1.SelectedTab.Name;
                }
                else
                {
                    MessageBox.Show("Filename can't be empty", "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
        }
        private void Open()
        {
            if (tabControl1.Controls.Count == 0)
            {
                AddTab();
            }
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "RTF|*.rtf|Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Length > 0)
                {

                    try
                    {
                        GetCurrentDocument.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.RetryCancel);
                    }

                }
            }

        }
        #endregion

        #region ClipBoard
        void Paste() => GetCurrentDocument.Paste();
        void Cut() => GetCurrentDocument.Cut();
        void Copy() => GetCurrentDocument.Copy();

        #endregion

        #region Font

        void Bold()
        {
            FontStyle currentFont = GetCurrentDocument.SelectionFont.Style;
            if (GetCurrentDocument.SelectionFont.Bold)
            {
                currentFont &= ~FontStyle.Bold;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                    GetCurrentDocument.SelectionFont.Size, currentFont);
            }

            else
            {
                currentFont |= FontStyle.Bold;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                   GetCurrentDocument.SelectionFont.Size, currentFont);
            }

        }

        void Italic()
        {
            FontStyle currentFont = GetCurrentDocument.SelectionFont.Style;
            if (GetCurrentDocument.SelectionFont.Italic)
            {
                currentFont &= ~FontStyle.Italic;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                   GetCurrentDocument.SelectionFont.Size, currentFont);
            }
            else
            {
                currentFont |= FontStyle.Italic;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                    GetCurrentDocument.SelectionFont.Size, currentFont);
            }

        }

        void Underline()
        {
            FontStyle currentFont = GetCurrentDocument.SelectionFont.Style;
            if (GetCurrentDocument.SelectionFont.Underline)
            {
                currentFont &= ~FontStyle.Underline;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                   GetCurrentDocument.SelectionFont.Size, currentFont);
            }
            else
            {
                currentFont |= FontStyle.Underline;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                    GetCurrentDocument.SelectionFont.Size, currentFont);
            }

        }

        void StrikeThrough()
        {
            FontStyle currentFont = GetCurrentDocument.SelectionFont.Style;
            if (GetCurrentDocument.SelectionFont.Strikeout)
            {
                currentFont &= ~FontStyle.Strikeout;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                   GetCurrentDocument.SelectionFont.Size, currentFont);
            }
            else
            {
                currentFont |= FontStyle.Strikeout;
                GetCurrentDocument.SelectionFont = new Font(GetCurrentDocument.SelectionFont.FontFamily,
                    GetCurrentDocument.SelectionFont.Size, currentFont);
            }

        }

        void font()
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                GetCurrentDocument.SelectionFont = fontDialog1.Font;
            }
        }

        void FontColor()
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                GetCurrentDocument.SelectionColor = fontDialog1.Color;
            }
        }

        void UpperCase()
        {
            GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToUpper();
        }

        void LowerCase()
        {
            GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToLower();
        }

        #endregion

        #region Allignment
        void left()
        {
            GetCurrentDocument.SelectionAlignment = HorizontalAlignment.Left;
        }
        void center()
        {
            GetCurrentDocument.SelectionAlignment = HorizontalAlignment.Center;
        }
        void right()
        {
            GetCurrentDocument.SelectionAlignment = HorizontalAlignment.Right;
        }
        #endregion

        #endregion

    
    }
}
