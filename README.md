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

### **🏗️ Technical Architecture (OOP Principles)**

| Principle | Implementation in FITPAL |
| :--- | :--- |
| 🛡️ **Encapsulation** | All fields such as age, weight, height, and password are declared private and accessed through public properties with validation. This ensures that invalid data cannot be assigned, maintaining data integrity and security. |
| 🧬 **Inheritance** |A hierarchical relationship is implemented as Person → User → FitnessUser. The FitnessUser class inherits general attributes from Person and User while adding fitness-specific properties like weight, height, and goals, promoting code reuse and logical structure. |
| 🎭 **Polymorphism** | MPolymorphism is achieved through method overriding. The method CalculateDailyCalories() is defined abstractly in Person, given a default implementation in User, and overridden in FitnessUser to provide a more accurate calculation. This allows the same method call to produce different results depending on the object type. |
| 🔍 **Abstraction** | The system uses an abstract class Person to define common behaviors such as GetSummary() and CalculateDailyCalories() without providing their implementation. This allows derived classes to implement their own logic while hiding complexity from the user. |

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
