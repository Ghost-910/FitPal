using System;
using System.Collections.Generic;

namespace FITPAL.Models
{
    public enum FitnessGoal
    {
        WeightLoss,
        Maintenance,
        MuscleGain
    }

    public class FitnessUser : User
    {
        private double _weightKg;
        private double _heightCm;
        private FitnessGoal _goal;
        private List<ProgressEntry> _progressLog;

        public double WeightKg
        {
            get { return _weightKg; }
            set
            {
                if (value <= 0 || value > 500)
                    throw new ArgumentOutOfRangeException(nameof(value), "Weight must be between 1 and 500 kg.");
                _weightKg = value;
            }
        }

        public double HeightCm
        {
            get { return _heightCm; }
            set
            {
                if (value <= 0 || value > 300)
                    throw new ArgumentOutOfRangeException(nameof(value), "Height must be between 1 and 300 cm.");
                _heightCm = value;
            }
        }

        public FitnessGoal Goal
        {
            get { return _goal; }
            set { _goal = value; }
        }

        public List<ProgressEntry> ProgressLog => _progressLog;

        public FitnessUser(string username, string password, string name, int age, string gender,
                           double weightKg, double heightCm, FitnessGoal goal)
            : base(username, password, name, age, gender)
        {
            WeightKg = weightKg;
            HeightCm = heightCm;
            Goal = goal;
            _progressLog = new List<ProgressEntry>();
        }

        public double CalculateBMI()
        {
            double heightM = HeightCm / 100.0;
            return Math.Round(_weightKg / (heightM * heightM), 2);
        }

        public string GetBMICategory()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25.0) return "Normal weight";
            if (bmi < 30.0) return "Overweight";
            return "Obese";
        }

        //TDEE (maintenance calories) using the Mifflin-St Jeor Equation
        public override double CalculateDailyCalories(FitnessGoal goal = FitnessGoal.Maintenance)
        {
            double bmr;
            if (Gender == "Male")
                bmr = (10 * WeightKg) + (6.25 * HeightCm) - (5 * Age) + 5;
            else
                bmr = (10 * WeightKg) + (6.25 * HeightCm) - (5 * Age) - 161;

            double tdee = bmr * 1.375;

            switch (goal)
            {
                case FitnessGoal.WeightLoss:  return Math.Round(tdee - 500, 0);
                case FitnessGoal.MuscleGain:  return Math.Round(tdee + 300, 0);
                default:                       return Math.Round(tdee, 0);
            }
        }

        public (double Protein, double Carbs, double Fats) GetMacros()
        {
            double calories = CalculateDailyCalories(_goal);
            double protein, carbs, fats;

            switch (_goal)
            {
                case FitnessGoal.WeightLoss:
                    protein = Math.Round((_weightKg * 2.0), 1);
                    fats    = Math.Round((calories * 0.25) / 9, 1);
                    carbs   = Math.Round((calories - (protein * 4) - (fats * 9)) / 4, 1);
                    break;
                case FitnessGoal.MuscleGain:
                    protein = Math.Round((_weightKg * 2.2), 1);
                    fats    = Math.Round((calories * 0.20) / 9, 1);
                    carbs   = Math.Round((calories - (protein * 4) - (fats * 9)) / 4, 1);
                    break;
                default:
                    protein = Math.Round((_weightKg * 1.6), 1);
                    fats    = Math.Round((calories * 0.30) / 9, 1);
                    carbs   = Math.Round((calories - (protein * 4) - (fats * 9)) / 4, 1);
                    break;
            }
            return (protein, carbs, fats);
        }

        public virtual List<string> GetExercisePlan()
        {
            var plan = new List<string>();
            switch (_goal)
            {
                case FitnessGoal.WeightLoss:
                    plan.Add("🏃 Monday    — 30 min cardio (running/cycling) + 15 min core");
                    plan.Add("🏋️ Tuesday   — Full-body circuit training (3 sets x 12 reps)");
                    plan.Add("🧘 Wednesday — Active rest: yoga / light stretching 30 min");
                    plan.Add("🏃 Thursday  — 40 min HIIT cardio");
                    plan.Add("🏋️ Friday    — Upper body: push/pull exercises");
                    plan.Add("🚴 Saturday  — 45 min low-intensity cardio (walk/swim)");
                    plan.Add("😴 Sunday    — Full rest day");
                    break;
                case FitnessGoal.MuscleGain:
                    plan.Add("🏋️ Monday    — Chest & Triceps: bench press, dips, flyes");
                    plan.Add("🏋️ Tuesday   — Back & Biceps: deadlift, rows, curls");
                    plan.Add("🦵 Wednesday — Legs: squats, lunges, leg press");
                    plan.Add("🏋️ Thursday  — Shoulders & Traps: OHP, lateral raises");
                    plan.Add("🔁 Friday    — Full-body compound lifts");
                    plan.Add("🧘 Saturday  — Active recovery: light stretching");
                    plan.Add("😴 Sunday    — Full rest day");
                    break;
                default:
                    plan.Add("🏃 Monday    — 30 min moderate cardio");
                    plan.Add("🏋️ Tuesday   — Full-body strength (3 sets x 10 reps)");
                    plan.Add("🧘 Wednesday — Yoga / flexibility training 30 min");
                    plan.Add("🏃 Thursday  — 30 min brisk walk or jog");
                    plan.Add("🏋️ Friday    — Bodyweight circuit training");
                    plan.Add("🚴 Saturday  — Leisure activity (sport, swim, hike)");
                    plan.Add("😴 Sunday    — Rest");
                    break;
            }
            return plan;
        }

        public void LogProgress(double weightKg, string notes = "")
        {
            _progressLog.Add(new ProgressEntry(DateTime.Now, weightKg, notes));
        }

        public override string GetSummary()
        {
            return $"User: {Name} | Age: {Age} | Gender: {Gender} | " +
                   $"Weight: {WeightKg}kg | Height: {HeightCm}cm | Goal: {Goal}";
        }
    }

    public class ProgressEntry
    {
        public DateTime Date { get; }
        public double WeightKg { get; }
        public string Notes { get; }

        public ProgressEntry(DateTime date, double weightKg, string notes)
        {
            Date = date;
            WeightKg = weightKg;
            Notes = notes;
        }
    }
}