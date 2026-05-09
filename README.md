<div align="center">

```txt
               ███████╗██╗████████╗██████╗  █████╗ ██╗
               ██╔════╝██║╚══██╔══╝██╔══██╗██╔══██╗██║
               █████╗  ██║   ██║   ██████╔╝███████║██║
               ██╔══╝  ██║   ██║   ██╔═══╝ ██╔══██║██║
                    ██║     ██║   ██║   ██║     ██║  ██║███████╗
                    ╚═╝     ╚═╝   ╚═╝   ╚═╝     ╚═╝  ╚═╝╚══════╝
```
### Personalized Fitness and Nutrition Coach

</div>

---

## 📋 Project Overview

**FITPAL** is a sophisticated **C# Windows Forms** application engineered to serve as a comprehensive **digital health assistant**. Developed for **CS 222 – Advanced Object-Oriented Programming**, this system provides an accessible solution for individuals—specifically students and fitness beginners—who require **personalized health guidance** without the expense of professional trainers.

By synthesizing user metrics such as **age, weight, and height** with specific health objectives, **FITPAL** delivers actionable **nutrition and exercise strategies** to help users achieve their desired physical outcomes.

---

## 📐 UML Diagram

![FITPAL UML Diagram](https://github.com/Ghost-910/FitPal/blob/main/Images%20and%20assets/Uml%20diagram.jpg)

---

# ✨ Features and Functionalities of the System

![Dashboard](https://github.com/Ghost-910/FitPal/blob/main/Images%20and%20assets/FITPAL%20Dashboard.png)

| Feature | Description |
| :--- | :--- |
| 👤 **User Profile Management** | Securely captures and maintains **age, weight, height, and target goals**. |
| 📉 **Biometric Analysis** | Integrated **BMI Calculator** for automated health assessment. |
| 🥗 **Precision Calorie Mapping** | Automated **Calorie Calculator** suggesting intake levels based on goals. |
| 🍎 **Nutrition Strategy** | **Nutrition Guide** recommending optimal macro distribution (protein/carbs/fat). |
| 🏋️‍♂️ **Adaptive Exercise Plans** | Dynamic workout routines for **weight loss, muscle gain, or maintenance**. |
| 📊 **Progress Tracking** | Uses a `DataGridView` to log and monitor **weight fluctuations** over time. |
| 🔐 **Secure Authentication** | Dedicated **Login and Registration System** for data privacy. |

---

# 🏗️ Technical Architecture (OOP Principles)

| Principle | Implementation in FITPAL |
| :--- | :--- |
| 🛡️ **Encapsulation** | All fields such as age, weight, height, and password are declared private and accessed through public properties with validation. This ensures that invalid data cannot be assigned, maintaining data integrity and security. |
| 🧬 **Inheritance** | A hierarchical relationship is implemented as `Person → User → FitnessUser`. The `FitnessUser` class inherits general attributes from `Person` and `User` while adding fitness-specific properties like weight, height, and goals, promoting code reuse and logical structure. |
| 🎭 **Polymorphism** | Polymorphism is achieved through method overriding. The method `CalculateDailyCalories()` is defined abstractly in `Person`, given a default implementation in `User`, and overridden in `FitnessUser` to provide a more accurate calculation. |
| 🔍 **Abstraction** | The system uses an abstract class `Person` to define common behaviors such as `GetSummary()` and `CalculateDailyCalories()` without providing their implementation. Derived classes implement their own logic while hiding complexity from the user. |

---

# ⚙️ Explanation of How the Program Works

FITPAL operates as a user-centered fitness tracking system that processes personal data to generate health-related recommendations. The workflow of the system is structured as follows:

---

## 🔐 1. User Authentication

When the application starts, the user is presented with a login interface.

Users can:

- Log in using existing credentials
- Register a new account

The system validates all inputs to ensure correctness and security before allowing access.

---

## 📝 2. Data Input and Validation

During registration, users provide personal and fitness-related information such as:

- Name
- Age
- Gender
- Weight
- Height
- Fitness Goal

All inputs are validated using encapsulated properties to prevent invalid or unrealistic values such as:

- Negative weight
- Invalid age
- Empty usernames or passwords

---

## 🧠 3. Object Creation and Data Handling

Once registered or logged in, a `FitnessUser` object is created.

This object stores all user-related information and serves as the central entity for processing:

- BMI calculations
- Calorie calculations
- Macronutrient distribution
- Exercise recommendations
- Progress tracking

The application uses object-oriented programming principles to organize and process the data efficiently.

---

## 📊 4. Dashboard Processing

After successful login, the system navigates to the dashboard where important health metrics are displayed.

The application automatically calculates:

- **Body Mass Index (BMI)**
- **Daily Calorie Requirements**
- **Protein Intake**
- **Macronutrient Distribution**
- **Fitness Goal Summary**

These calculations are performed dynamically using methods inside the `FitnessUser` class.

---

## 🏋️ 5. Fitness Modules Execution

FITPAL contains several functional modules:

### 📉 BMI Module
Displays:
- BMI value
- BMI category
- Health classification

### 🔥 Calorie Calculator
Calculates:
- Daily calorie requirements
- Goal-based calorie adjustments

### 🍎 Nutrition Guide
Provides:
- Protein recommendations
- Carbohydrate recommendations
- Fat recommendations

### 🏃 Exercise Plan Generator
Generates:
- Weekly exercise plans
- Goal-specific workout routines

Each module dynamically retrieves and processes user data.

---

## 📈 6. Progress Tracking

Users can log their body weight over time.

Each entry is stored as a `ProgressEntry` object and added to a collection.

The system displays:
- Weight history
- Date of entry
- Weight changes

Data is presented using a `DataGridView`.

---

## 🔓 7. Session Management

The user can log out at any time.

The application safely:
- Ends the session
- Clears temporary data
- Returns to the login screen

---

# 🚀 Instructions on How to Run the Application

Follow the steps below carefully to run FITPAL successfully.

---

## 💻 Step 1 — Install Visual Studio 2022

Download and install:

- **Visual Studio 2022 Community Edition**

Official Website:

```txt
https://visualstudio.microsoft.com/
```

During installation, make sure to select:

```txt
.NET desktop development
```

This workload is required for Windows Forms applications.

---

## ⚙️ Step 2 — Verify .NET 8 Installation

Open Command Prompt or Terminal and type:

```bash
dotnet --version
```

Expected output:

```txt
8.x.x
```

If .NET 8 is not installed, install the latest .NET SDK.

---

## 📦 Step 3 — Download or Clone the Project

###  Download the Files

Download the project file.

---

## 📁 Step 4 — Verify Project Structure

The project folder should contain:

```txt
FITPAL/
├── fitpal.csproj
├── Program.cs
├── LoginForm.cs
├── LoginForm.Designer.cs
├── DashboardForm.cs
├── DashboardForm.Designer.cs
├── Models/
│   ├── User.cs
│   └── FitnessUser.cs
└── Services/
    └── UserRepository.cs
```

---

## 🖥️ Step 5 — Open the Project

1. Open **Visual Studio 2022**
2. Click:

```txt
Open a project or solution
```

3. Navigate to the project folder
4. Open:

```txt
fitpal.csproj
```

---

## 🛠️ Step 6 — Fix Target Framework (If Needed)

If Visual Studio shows a framework error:

Open:

```txt
fitpal.csproj
```

Find:

```xml
<TargetFramework>net6.0-windows</TargetFramework>
```

Replace with:

```xml
<TargetFramework>net8.0-windows</TargetFramework>
```

Save the file.

---

## ▶️ Step 7 — Build and Run the Application

### Build the Project

Click:

```txt
Build → Rebuild Solution
```

Wait until:

```txt
Build succeeded
```

appears.

---

### Run the Application

Press:

```txt
F5
```

or click the green Run button.

The FITPAL Login screen should appear.

---

## 🔑 Step 8 — Login Using the Demo Account

Use the preloaded demo credentials:

```txt
Username: demo
Password: demo123
```

---

## 🧪 Step 9 — Test the Features

Explore the system modules:

- Overview
- BMI
- Calories
- Nutrition
- Exercise Plan
- Progress Tracking

You may also:
- Register a new account
- Log weight progress
- Generate exercise plans

---

# 📊 Calculations Used in FITPAL

---

## 📉 BMI Formula

```txt
BMI = Weight (kg) ÷ Height² (m²)
```

### Example

```txt
Height = 175 cm = 1.75 m

BMI = 75 ÷ (1.75 × 1.75)
BMI = 24.49
```

### BMI Categories

| Category | BMI Range |
|---|---|
| Underweight | Below 18.5 |
| Normal Weight | 18.5 – 24.9 |
| Overweight | 25.0 – 29.9 |
| Obese | 30 and above |

---

## 🔥 Calorie Calculation

FITPAL uses the **Mifflin-St Jeor Equation**.

### Male

```txt
BMR = (10 × weight) + (6.25 × height) − (5 × age) + 5
```

### Female

```txt
BMR = (10 × weight) + (6.25 × height) − (5 × age) − 161
```

### TDEE Formula

```txt
TDEE = BMR × 1.375
```

### Goal Adjustments

| Goal | Adjustment |
|---|---|
| Weight Loss | TDEE − 500 kcal |
| Maintenance | No Change |
| Muscle Gain | TDEE + 300 kcal |

---


# 👥 Project Contributors: Cool Pals (Team 12)

**Section:** CS-2203

| 👤 Name | 🛠️ Role | 📝 Responsibilities |
| :--- | :--- | :--- |
| **Bulaon, Vhenise Rich Cole** | **Developer** | Data handling, calculations, and feature integration |
| **De Castro, Aicert Reimiel** | **Developer and UI Designer** | System logic, coding, design, layout, and OOP implementation |
| **Santiago, Francis** | **UI Designer** | Form design, layout, and user interface |

---

# 📄 License

This project is for educational purposes only.
