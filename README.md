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

### ⚙️ **Explanation of how the program run and works**
FITPAL operates as a user-centered fitness tracking system that processes personal data to generate health-related recommendations. The workflow of the system is structured as follows:


### 🔐 1. User Authentication

When the application starts, the user is presented with a login interface. Users can either log in using existing credentials or create a new account through the registration form. The system validates all inputs to ensure correctness and security.


### 📝 2. Data Input and Validation

During registration, users provide personal and fitness-related information such as:

- Name  
- Age  
- Gender  
- Weight  
- Height  
- Fitness Goal  

All inputs are validated using encapsulated properties to prevent invalid or unrealistic values (e.g., negative weight or invalid age).


### 🧠 3. Object Creation and Data Handling

Once registered or logged in, a `FitnessUser` object is created. This object stores all user-related data and serves as the core entity for processing:

- BMI calculation  
- Calorie requirements  
- Macronutrient distribution  


### 📊 4. Dashboard Processing

After login, the system navigates to the dashboard where key fitness metrics are displayed. The application automatically calculates:

- **Body Mass Index (BMI)** using height and weight  
- **Daily Calorie Requirements** based on the user’s goal  
- **Macronutrient Distribution** (protein, carbohydrates, and fats)  

These computations are performed using methods defined in the `FitnessUser` class.


### 🏋️ 5. Fitness Modules Execution

The system provides multiple functional modules:

- **BMI Module** – Displays BMI value and corresponding category  
- **Calorie Calculator** – Computes daily calorie intake using a standard formula  
- **Nutrition Guide** – Suggests macro distribution based on fitness goals  
- **Exercise Plan Generator** – Produces a weekly workout plan tailored to the user’s objective  

Each module retrieves and processes data dynamically from the user object.


### 📈 6. Progress Tracking

Users can log their weight over time. Each entry is stored as a `ProgressEntry` object and added to a collection.

- Data is displayed in a table format (DataGridView)  
- Users can monitor progress and weight changes over time  


### 🔓 7. Session Management
- The user can log out at any time, which safely ends the session and returns the application to the login screen.
---

The user can log out at any time, which safely ends the session and returns the application to the login screen.

### 👥 **Project Contributors: Cool Pals (Team 12)**

**Section**: **CS-2203**

| 👤 Name | 🛠️ Role | 📝 Responsibilities |
| :--- | :--- | :--- |
| **Bulaon, Vhenise Rich Cole** | **Developer** | Data handling, calculations, and feature integration |
| **De Castro, Aicert Reimiel** | **Developer** | System logic, coding, and **OOP implementation** |
| **Santiago, Francis** | **UI Designer** | Design forms, layout, and **user interface** |

---
