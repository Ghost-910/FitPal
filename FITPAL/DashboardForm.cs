using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using fitpal.Services;
using fitpal.Models;

namespace fitpal
{
    public partial class DashboardForm : Form
    {
        private FitnessUser _user;
        private Button _activeBtn;

        private readonly Color BG_FORM = Color.FromArgb(13, 19, 33);
        private readonly Color BG_SIDEBAR = Color.FromArgb(16, 24, 40);
        private readonly Color BG_HEADER = Color.FromArgb(16, 24, 40);
        private readonly Color BG_CARD = Color.FromArgb(22, 30, 48);
        private readonly Color BG_ROW = Color.FromArgb(25, 34, 54);
        private readonly Color CLR_TEAL = Color.FromArgb(0, 212, 170);
        private readonly Color CLR_ORANGE = Color.FromArgb(255, 167, 38);
        private readonly Color CLR_BLUE = Color.FromArgb(66, 165, 245);
        private readonly Color CLR_PURPLE = Color.FromArgb(186, 104, 200);
        private readonly Color CLR_RED = Color.FromArgb(255, 90, 90);
        private readonly Color TXT_PRIMARY = Color.FromArgb(230, 240, 255);
        private readonly Color TXT_SECONDARY = Color.FromArgb(160, 180, 210);
        private readonly Color TXT_HINT = Color.FromArgb(110, 130, 165);
        private readonly Color BORDER_LINE = Color.FromArgb(35, 50, 75);

        
        private const int CX = 20;   
        private const int CW = 875;  
        private const int CGAP = 12; 

        private const int TITLE_Y = 18;
        private const int CONTENT_START = 70;  

        public DashboardForm(FitnessUser user)
        {
            InitializeComponent();
            _user = user;
            this.Text = $"FITPAL - Welcome, {user.Name}";
            lblUserInfo.Text = $" {user.Name} | Goal: {user.Goal}";
            ApplyStyling();
            HighlightButton(btnOverview);
            ShowOverview();
        }

        private void ApplyStyling()
        {
            this.BackColor = BG_FORM;
            pnlHeader.BackColor = BG_HEADER;
            pnlSidebar.BackColor = BG_SIDEBAR;
            pnlContent.BackColor = BG_FORM;

            lblLogo.ForeColor = CLR_TEAL;
            lblLogo.Font = new Font("Segoe UI", 15f, FontStyle.Bold);
            lblUserInfo.ForeColor = TXT_SECONDARY;
            lblUserInfo.Font = new Font("Segoe UI", 9f);

            Button[] navBtns = { btnOverview, btnBMI, btnCalories,
                                  btnNutrition, btnExercise, btnProgress };
            foreach (var btn in navBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 0, 212, 170);
                btn.BackColor = Color.Transparent;
                btn.ForeColor = TXT_SECONDARY;
                btn.Font = new Font("Segoe UI", 10f);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(14, 0, 0, 0);
                btn.Cursor = Cursors.Hand;
            }
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.ForeColor = CLR_RED;
            btnLogout.Font = new Font("Segoe UI", 10f);
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Cursor = Cursors.Hand;
        }

        private void HighlightButton(Button btn)
        {
            if (_activeBtn != null)
            {
                _activeBtn.BackColor = Color.Transparent;
                _activeBtn.ForeColor = TXT_SECONDARY;
                _activeBtn.Font = new Font("Segoe UI", 10f);
            }
            btn.BackColor = Color.FromArgb(25, 0, 212, 170);
            btn.ForeColor = CLR_TEAL;
            btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            _activeBtn = btn;
        }
        private void ClearContent()
        {
            pnlContent.Controls.Clear();
        }

        private void AddTitle(string icon, string titleText)
        {
            pnlContent.Controls.Add(new Label
            {
                Text = icon,
                Location = new Point(CX, TITLE_Y),
                AutoSize = true,
                Font = new Font("Segoe UI", 17f),
                ForeColor = TXT_PRIMARY
            });
            pnlContent.Controls.Add(new Label
            {
                Text = titleText,
                Location = new Point(CX + 46, TITLE_Y + 2),
                AutoSize = true,
                Font = new Font("Segoe UI", 17f, FontStyle.Bold),
                ForeColor = TXT_PRIMARY
            });
        }
        private void AddDivider(int y)
        {
            pnlContent.Controls.Add(new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(CW, 1),
                BackColor = BORDER_LINE
            });
        }

        private void AddSectionHeader(string text, int y)
        {
            pnlContent.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(CX, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = CLR_TEAL
            });
        }

        private void AddBulletRow(string text, int y)
        {
            pnlContent.Controls.Add(new Label
            {
                Text = $"•  {text}",
                Location = new Point(CX + 10, y),
                Size = new Size(CW - 10, 26),
                ForeColor = TXT_PRIMARY,
                Font = new Font("Segoe UI", 10f)
            });
        }

        private void AddTextRow(string text, int y)
        {
            pnlContent.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(CX + 10, y),
                Size = new Size(CW - 10, 26),
                ForeColor = TXT_PRIMARY,
                Font = new Font("Segoe UI", 10f)
            });
        }

        private Panel MakeStatCard(string title, string value, string subtitle,
                                   Color accent, int x, int y, int w, int h = 130)
        {
            var card = new Panel
            {
                Location = new Point(x, y ),
                Size = new Size(w, h),
                BackColor = BG_CARD
            };
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(accent, 3))
                    e.Graphics.DrawLine(pen, 0, 0, card.Width, 0);
            };
            card.Controls.Add(new Label
            {
                Text = title,
                Location = new Point(12, 12),
                AutoSize = true,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = TXT_HINT
            });
            card.Controls.Add(new Label
            {
                Text = value,
                Location = new Point(12, 32),
                Size = new Size(w - 20, 44),
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = accent
            });
            card.Controls.Add(new Label
            {
                Text = subtitle,
                Location = new Point(12, 88),
                AutoSize = true,
                Font = new Font("Segoe UI", 8f),
                ForeColor = TXT_HINT
            });
            return card;
        }


        private Panel MakeBigStatCard(string title, string value, string subtitle,
                                      Color accent, int y, int h = 120)
        {
            var card = new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(CW, h),
                BackColor = BG_CARD
            };
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(accent, 4))
                    e.Graphics.DrawLine(pen, 0, 0, 0, card.Height);
            };
            card.Controls.Add(new Label
            {
                Text = title,
                Location = new Point(18, 14),
                AutoSize = true,
                Font = new Font("Segoe UI", 10f),
                ForeColor = TXT_SECONDARY
            });
            card.Controls.Add(new Label
            {
                Text = value,
                Location = new Point(18, 36),
                AutoSize = true,
                Font = new Font("Segoe UI", 26f, FontStyle.Bold),
                ForeColor = accent
            });
            card.Controls.Add(new Label
            {
                Text = subtitle,
                Location = new Point(18, 88),
                AutoSize = true,
                Font = new Font("Segoe UI", 9f),
                ForeColor = TXT_HINT
            });
            return card;
        }

        private Panel MakeTableRow(string label, string value,
                                   Color valueColor, bool isActive,
                                   int y, int w = 760, int h = 48)
        {
            var row = new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(w, h),
                BackColor = isActive ? Color.FromArgb(18, 0, 160, 90) : BG_ROW
            };
            if (isActive)
            {
                row.Paint += (s, e) =>
                {
                    using (var pen = new Pen(CLR_TEAL, 3))
                        e.Graphics.DrawLine(pen, 0, 0, 0, row.Height);
                };
            }
            row.Controls.Add(new Label
            {
                Text = isActive ? $"▶  {label}" : $"    {label}",
                Location = new Point(10, 13),
                AutoSize = true,
                ForeColor = isActive ? CLR_TEAL : TXT_PRIMARY,
                Font = new Font("Segoe UI", 10f,
                    isActive ? FontStyle.Bold : FontStyle.Regular)
            });
            row.Controls.Add(new Label
            {
                Text = value,
                Location = new Point(w - 200, 13),
                AutoSize = true,
                ForeColor = valueColor,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold)
            });
            return row;
        }

        private Panel MakeExerciseRow(string text, int y)
        {
            var row = new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(CW, 48),
                BackColor = BG_ROW
            };
            row.Paint += (s, e) =>
            {
                using (var pen = new Pen(CLR_TEAL, 3))
                    e.Graphics.DrawLine(pen, 0, 0, 0, row.Height);
            };
            row.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(14, 13),
                AutoSize = true,
                ForeColor = TXT_PRIMARY,
                Font = new Font("Segoe UI", 10f)
            });
            return row;
        }

        private Panel MakeMacroCard(string title, string grams, string kcal,
                                    string desc, Color accent,
                                    int x, int y, int w)
        {
            var card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, 150),
                BackColor = BG_CARD
            };
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(accent, 3))
                    e.Graphics.DrawLine(pen, 0, 0, card.Width, 0);
            };
            card.Controls.Add(new Label
            {
                Text = title,
                Location = new Point(12, 12),
                AutoSize = true,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = TXT_HINT
            });
            card.Controls.Add(new Label
            {
                Text = grams,
                Location = new Point(12, 32),
                AutoSize = true,
                Font = new Font("Segoe UI", 20f, FontStyle.Bold),
                ForeColor = accent
            });
            card.Controls.Add(new Label
            {
                Text = kcal,
                Location = new Point(12, 84),
                AutoSize = true,
                Font = new Font("Segoe UI", 9f),
                ForeColor = TXT_HINT
            });
            card.Controls.Add(new Label
            {
                Text = desc,
                Location = new Point(12, 106),
                AutoSize = true,
                Font = new Font("Segoe UI", 8f, FontStyle.Italic),
                ForeColor = TXT_HINT
            });
            return card;
        }

        private Panel MakeProgressHeader(int y)
        {
            var row = new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(CW, 36),
                BackColor = BG_CARD
            };
            void Col(string text, int lx) => row.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(lx, 9),
                AutoSize = true,
                ForeColor = CLR_TEAL,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold)
            });
            Col("Date", 12);
            Col("Weight (kg)", 300);
            Col("Change", 440);
            Col("Notes", 560);
            return row;
        }

        private Panel MakeProgressDataRow(string date, string weight,
                                          string change, string notes, int y)
        {
            Color changeColor = change.Contains("+") ? CLR_RED
                              : change == "—" ? TXT_SECONDARY
                              : CLR_TEAL;
            var row = new Panel
            {
                Location = new Point(CX, y),
                Size = new Size(CW, 42),
                BackColor = BG_FORM
            };
            void Col(string text, int lx, Color color, bool bold = false) =>
                row.Controls.Add(new Label
                {
                    Text = text,
                    Location = new Point(lx, 11),
                    AutoSize = true,
                    ForeColor = color,
                    Font = new Font("Segoe UI", 9.5f,
                        bold ? FontStyle.Bold : FontStyle.Regular)
                });
            Col(date, 12, TXT_PRIMARY);
            Col(weight, 300, TXT_PRIMARY);
            Col(change, 440, changeColor, true);
            Col(notes, 560, TXT_HINT);
            return row;
        }
        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowOverview()
        {
            ClearContent();

            
            AddTitle("🏠", "Dashboard Overview                                                                        ");

            double bmi = _user.CalculateBMI();
            double calories = _user.CalculateDailyCalories();
            var macros = _user.GetMacros();

            int cardH = 130;
            int cardW = (CW - CGAP * 3) / 4;      
            int cardY = CONTENT_START;             

            pnlContent.Controls.Add(MakeStatCard(
                "⚖  BMI",
                $"{bmi:F2}",
                _user.GetBMICategory(),
                CLR_TEAL,
                CX, cardY, cardW - 15, cardH));

            pnlContent.Controls.Add(MakeStatCard(
                "🔥  Daily Calories",
                $"{calories} kcal",
                "Target intake",
                CLR_ORANGE,
                CX + (cardW + CGAP), cardY, cardW - 15, cardH));

            pnlContent.Controls.Add(MakeStatCard(
                "🥩  Protein",
                $"{macros.Protein}g / day",
                "Daily target",
                CLR_BLUE,
                CX + (cardW + CGAP) * 2, cardY, cardW - 15, cardH));

            pnlContent.Controls.Add(MakeStatCard(
                "🎯  Goal",
                _user.Goal.ToString(),
                "Current goal",
                CLR_PURPLE,
                CX + (cardW + CGAP) * 3, cardY, cardW - 15, cardH));

            
            int y = cardY + cardH + 16;  
            AddDivider(y); y += 14;   
            AddSectionHeader("👤  Your Profile", y); y += 36; 

            AddBulletRow($"Name: {_user.Name}", y); y += 28;
            AddBulletRow($"Age: {_user.Age} years", y); y += 28;
            AddBulletRow($"Gender: {_user.Gender}", y); y += 28;
            AddBulletRow($"Weight: {_user.WeightKg} kg", y); y += 28;
            AddBulletRow($"Height: {_user.HeightCm} cm", y); y += 28;
            AddBulletRow($"Fitness Goal: {_user.Goal}", y);
        }

        private void ShowBMI()
        {
            ClearContent();
            AddTitle("⚖", "BMI Calculator");

            double bmi = _user.CalculateBMI();
            string cat = _user.GetBMICategory();

            
            pnlContent.Controls.Add(MakeBigStatCard(
                "Your BMI", $"{bmi:F1}", cat,
                CLR_TEAL, 64));

            int y = 200;
            AddSectionHeader("📊  BMI Categories", y); y += 36;

            
            var catRows = new[]
            {
                ("Underweight",   "< 18.5",      CLR_BLUE,   cat == "Underweight"),
                ("Normal weight", "18.5 – 24.9", CLR_TEAL,   cat == "Normal weight"),
                ("Overweight",    "25.0 – 29.9", CLR_ORANGE, cat == "Overweight"),
                ("Obese",         "≥ 30.0",      CLR_RED,    cat == "Obese"),
            };
            foreach (var (label, range, color, active) in catRows)
            {
                pnlContent.Controls.Add(MakeTableRow(label, range, color, active, y));
                y += 54;
            }

            y += 10;
            AddSectionHeader("ℹ  How BMI is Calculated", y); y += 36;
            AddBulletRow("BMI = Weight (kg) ÷ Height² (m²)", y); y += 28;
            double hm = _user.HeightCm / 100.0;
            AddBulletRow($"Your calculation: {_user.WeightKg} ÷ ({hm:F2})² = {bmi:F2}", y);
        }

        private void ShowCalories()
        {
            ClearContent();
            AddTitle("🔥", "Calorie Calculator");

            double loss = _user.CalculateDailyCalories(FitnessGoal.WeightLoss);
            double maint = _user.CalculateDailyCalories(FitnessGoal.Maintenance);
            double gain = _user.CalculateDailyCalories(FitnessGoal.MuscleGain);
            double yours = _user.CalculateDailyCalories(_user.Goal);

            pnlContent.Controls.Add(MakeBigStatCard(
                "Your Daily Target",
                $"{yours} kcal",
                $"Based on {_user.Goal} goal",
                CLR_ORANGE, 64));

            int y = 200;
            AddSectionHeader("📋  Calorie Breakdown by Goal", y); y += 36;

            var goalRows = new[]
            {
                ("🏃  Weight Loss", $"{loss} kcal/day",  CLR_BLUE,   _user.Goal == FitnessGoal.WeightLoss),
                ("⚖  Maintenance",  $"{maint} kcal/day", CLR_ORANGE, _user.Goal == FitnessGoal.Maintenance),
                ("💪  Muscle Gain", $"{gain} kcal/day",  CLR_PURPLE, _user.Goal == FitnessGoal.MuscleGain),
            };
            foreach (var (label, value, color, active) in goalRows)
            {
                pnlContent.Controls.Add(MakeTableRow(label, value, color, active, y));
                y += 54;
            }

            y += 10;
            AddSectionHeader("📐  Formula Used (Mifflin-St Jeor)", y); y += 36;
            string formula = _user.Gender == "Male"
                ? "BMR = (10 × weight) + (6.25 × height) − (5 × age) + 5"
                : "BMR = (10 × weight) + (6.25 × height) − (5 × age) − 161";
            AddBulletRow(formula, y); y += 28;
            AddBulletRow("TDEE = BMR × 1.375  (moderate activity)", y);
        }

        private void ShowNutrition()
        {
            ClearContent();

            
            AddTitle("🥗", "Nutrition Guide                                                             ");

            var m = _user.GetMacros();

            
            int secHeaderY = CONTENT_START;          
            AddSectionHeader("🎯  Your Daily Macros                                                                                         " +
                "                                  ", secHeaderY);

            
            int macroCardH = 150;
            int macroW = (CW - CGAP * 2) / 3;   
            int macroY = secHeaderY + 36;        

            pnlContent.Controls.Add(MakeMacroCard(
                "🥩  Protein",
                $"{m.Protein}g",
                $"{m.Protein * 4:F0} kcal",
                "Builds  repairs muscle",
                CLR_BLUE,
                CX, macroY, macroW - 50));

            pnlContent.Controls.Add(MakeMacroCard(
                "🍞  Carbohydrates",
                $"{m.Carbs}g",
                $"{m.Carbs * 4:F0} kcal",
                "Primary energy source",
                CLR_ORANGE,
                CX + macroW + CGAP, macroY, macroW - 50));

            pnlContent.Controls.Add(MakeMacroCard(
                "🥑  Fats",
                $"{m.Fats}g",
                $"{m.Fats * 9:F0} kcal",
                "Hormones  brain health",
                CLR_TEAL,
                CX + (macroW + CGAP) * 2, macroY, macroW - 50));

            
            int y = macroY + macroCardH + 14;   
            AddDivider(y); y += 14;              
            AddSectionHeader("💡  Food Recommendations", y); y += 36; 

            string[] foods;
            if (_user.Goal == FitnessGoal.WeightLoss)
                foods = new[] {
                    "🥦  Vegetables — broccoli, spinach, kale (low-calorie, high-fiber)",
                    "🍗  Lean protein — chicken breast, turkey, egg whites, tofu",
                    "🐟  Fish — salmon, tuna, tilapia (high protein, healthy fats)",
                    "🫐  Fruits — berries, apples, oranges (low glycemic index)",
                    "🌾  Whole grains — brown rice, oats, quinoa (complex carbs)",
                };
            else if (_user.Goal == FitnessGoal.MuscleGain)
                foods = new[] {
                    "🥩  Red meat — beef, lamb (creatine, iron, protein)",
                    "🥚  Whole eggs — complete protein with healthy fats",
                    "🍚  White rice and pasta — fast carbs for post-workout energy",
                    "🧀  Dairy — Greek yogurt, cottage cheese, milk",
                    "🥜  Nuts and nut butter — healthy fats plus extra calories",
                };
            else
                foods = new[] {
                    "🥗  Balanced meals — variety of vegetables and proteins",
                    "🍎  Fresh fruits — 2 to 3 servings per day",
                    "🌾  Whole grains — oats, brown rice, whole wheat",
                    "💧  Hydration — 8 to 10 glasses of water daily",
                    "🐟  Lean protein — fish, chicken, legumes",
                };

            foreach (var food in foods) { AddTextRow(food, y); y += 34; }
        }

        private void ShowExercise()
        {
            ClearContent();
            AddTitle("🏋", "Exercise Plan                                                                                                    ");

            var plan = _user.GetExercisePlan();

            int y = 64;
            AddSectionHeader($"Weekly Plan — {_user.Goal}", y); y += 38;

            foreach (var day in plan)
            {
                pnlContent.Controls.Add(MakeExerciseRow(day, y));
                y += 54;
            }

            y += 8;
            AddSectionHeader("⏱  Training Tips", y); y += 38;

            string[] tips = {
                "☑  Warm up for 5–10 minutes before every session",
                "☑  Stay hydrated — drink water before, during, and after",
                "☑  Rest at least 48 hours between training the same muscle group",
                "☑  Track your progress to stay motivated and adjust intensity"
            };
            foreach (var tip in tips) { AddTextRow(tip, y); y += 32; }
        }
        private void ShowProgress()
        {
            ClearContent();
            AddTitle("📈", "Progress Tracker                                                                                          ");

            int y = CONTENT_START;
            AddSectionHeader("➕  Log Today's Weight", y); y += 40;

            int nudW = 180;
            int btnLogW = 100;
            int notesW = CW - nudW - btnLogW - CGAP * 2;

            var nudWeight = new NumericUpDown
            {
                Location = new Point(CX, y),
                Size = new Size(nudW, 34),
                Minimum = 30,
                Maximum = 300,
                Value = (decimal)_user.WeightKg,
                DecimalPlaces = 1,
                Increment = 0.5m,
                BackColor = BG_CARD,
                ForeColor = TXT_PRIMARY,
                Font = new Font("Segoe UI", 11f)
            };
            pnlContent.Controls.Add(nudWeight);

            var txtNotes = new TextBox
            {
                Location = new Point(CX + nudW + CGAP, y),
                Size = new Size(notesW, 34),
                BackColor = BG_CARD,
                ForeColor = TXT_SECONDARY,
                Font = new Font("Segoe UI", 10f),
                BorderStyle = BorderStyle.FixedSingle,
                PlaceholderText = "Optional notes..."
            };
            pnlContent.Controls.Add(txtNotes);

            var btnLog = new Button
            {
                Text = "LOG",
                Location = new Point(CX + nudW + CGAP + notesW + CGAP, y),
                Size = new Size(btnLogW, 34),
                BackColor = CLR_TEAL,
                ForeColor = Color.FromArgb(13, 19, 33),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLog.FlatAppearance.BorderSize = 0;
            pnlContent.Controls.Add(btnLog);
            y += 46;

            var lblMsg = new Label
            {
                Location = new Point(CX, y),
                AutoSize = true,
                ForeColor = CLR_TEAL,
                Font = new Font("Segoe UI", 9f, FontStyle.Italic),
                Text = ""
            };
            pnlContent.Controls.Add(lblMsg);
            y += 32;

            AddDivider(y); y += 14;
            AddSectionHeader("📋  Progress History", y); y += 38;

            if (_user.ProgressLog.Count == 0)
            {
                AddTextRow("No entries yet. Log your first weight above!", y);
            }
            else
            {
                pnlContent.Controls.Add(MakeProgressHeader(y)); y += 38;
                AddDivider(y); y += 6;

                double? prev = null;
                foreach (var entry in _user.ProgressLog)
                {
                    string change = prev.HasValue
                        ? $"{(entry.WeightKg - prev.Value):+0.0;-0.0} kg"
                        : "—";
                    pnlContent.Controls.Add(MakeProgressDataRow(
                        entry.Date.ToString("MMM dd, yyyy HH:mm"),
                        $"{entry.WeightKg} kg",
                        change, entry.Notes, y));
                    y += 42;
                    AddDivider(y); y += 4;
                    prev = entry.WeightKg;
                }
            }

            btnLog.Click += (s, e) =>
            {
                _user.LogProgress((double)nudWeight.Value, txtNotes.Text.Trim());
                lblMsg.Text = $"✔  Logged {nudWeight.Value} kg at {DateTime.Now:HH:mm}";
                txtNotes.Text = "";
                UserRepository.Instance.UpdateUser(_user);
                ShowProgress();
                HighlightButton(btnProgress);
            };
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            HighlightButton(btnOverview);
            ShowOverview();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBMI);
            ShowBMI();
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCalories);
            ShowCalories();
        }

        private void btnNutrition_Click(object sender, EventArgs e)
        {
            HighlightButton(btnNutrition);
            ShowNutrition();
        }

        private void btnExercise_Click(object sender, EventArgs e)
        {
            HighlightButton(btnExercise);
            ShowExercise();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProgress);
            ShowProgress();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOverview_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnOverview);
            ShowOverview();
        }

        private void btnBMI_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnBMI);
            ShowBMI();
        }

        private void btnCalories_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnCalories);
            ShowCalories();
        }

        private void btnNutrition_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnNutrition);
            ShowNutrition();
        }

        private void btnExercise_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnExercise);
            ShowExercise();
        }

        private void btnProgress_Click_1(object sender, EventArgs e)
        {
            HighlightButton(btnProgress);
            ShowProgress();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
