# 🏃‍♂️ **FITPAL: Personalized Fitness and Nutrition Tracker**

---

### 📋 **Project Overview**
**FITPAL** is a sophisticated **C# Windows Forms** application engineered to serve as a comprehensive **digital health assistant**. Developed for **CS 222 – Advanced Object-Oriented Programming**, this system provides an accessible solution for individuals—specifically students and fitness beginners—who require **personalized health guidance** without the expense of professional trainers.

By synthesizing user metrics such as **age, weight, and height** with specific health objectives, **FITPAL** delivers actionable **nutrition and exercise strategies** to help users achieve their desired physical outcomes.

---

### 📐 **System Design & UML**

---

### **✨Features and Functionalities of the System**

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

### **🏗️ echnical Architecture (OOP Principles)**

| Principle | Implementation in FITPAL |
| :--- | :--- |
| 🛡️ **Encapsulation** | User attributes are kept in **`private` fields** and accessed via **getters and setters** to ensure data integrity. |
| 🧬 **Inheritance** | A base `User` class handles general profiles, while a specialized **`FitnessUser` class** adds health-specific metrics. |
| 🎭 **Polymorphism** | Methods like `Calculate()` provide **different behaviors** depending on whether the user wants to gain or lose weight. |
| 🔍 **Abstraction** | Hides **complex BMR/BMI math** from the user, exposing only a simple interface for input and results. |

---

### ⚙️ **Explanation of how the program works**
1. **Authentication**: Users register or log in to their **personalized dashboard**.
2. **Input**: The user provides **biometric data** through a streamlined input form.
3. **Processing**: The system calculates health metrics using the **encapsulated OOP logic**.
4. **Delivery**: Results are displayed via the **Results/Recommendation Form**.
5. **Monitoring**: Ongoing progress is tracked through the **dedicated tracking module**.

---

### 👥 **Project Contributors: Cool Pals (Team 12)**

**Section**: **CS-2203**

| 👤 Name | 🛠️ Role | 📝 Responsibilities |
| :--- | :--- | :--- |
| **Bulaon, Vhenise Rich Cole** | **Developer** | Data handling, calculations, and feature integration |
| **De Castro, Aicert Reimiel** | **Developer** | System logic, coding, and **OOP implementation** |
| **Santiago, Francis** | **UI Designer** | Design forms, layout, and **user interface** |

---
