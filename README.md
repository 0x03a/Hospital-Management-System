# 🏥 Hospital Management System

## 📄 Project Overview

This Hospital Management System leverages **Oracle Database** and **Visual Studio** to efficiently manage patient records, staff roles, appointment schedules, and revenue tracking. It aims to streamline healthcare operations, enhance administrative control, and improve financial management.(used "Parameterized Sql query" to prevent Sql Injection, bcz "Sql query with string Concatentation" or "Non-Paramerterized Sql query" can cause Sql injection. )

### 🔧 Features

- OTP-based patient registration system  
- Profile viewing for patients, doctors, and nurses  
- Appointment scheduling module  
- Role-based access control:  
  - Nurses can only view profiles  
  - Admins can perform full CRUD operations  
- Revenue report generation (PDF export)

---

## 💼 Responsibilities

- **Database Developer**  
- **Backend Developer**  
- **Admin**  
- **Receptionist**  
- **Doctor**  
- **Nurse**

---

## 📎 Project Scope

- 📌 Patient Registration with OTP  
- 📌 Appointment Scheduling  
- 📌 Profile View Functionality  
- 📌 Record Tracking & Management  
- 📌 Admin Controls (Add/Delete/Update)  
- 📌 PDF Report Generation for Revenue

---

## 📥 Queries File

📄 [Download Queries.txt](https://github.com/user-attachments/files/19820374/Queries.txt)

---

## 💻 Dependencies

### 🧩 Required Tools & Versions

| Tool               | Version                  |
|--------------------|---------------------------|
| Visual Studio      | 2019 / 2022 Community     |
| Oracle Database    | Oracle 11g (Mandatory)    |
| .NET Framework     | See list below            |

🔗 **Oracle 11g Download:**  
[https://www.oracle.com/database/technologies/xe-prior-release-downloads.html](https://www.oracle.com/database/technologies/xe-prior-release-downloads.html)

🔧 **Oracle Tools for Visual Studio:**

- For **VS 2022**: Download `Oracle.VsDevTools.17.0`  
- For **VS 2019**: Download the appropriate version of `Oracle.VsDevTools`  

> ⚠️ Make sure Visual Studio is **closed** before installing the Oracle tools.

---

## 📦 Prerequisites for .NET in Visual Studio

Install the following in Visual Studio Installer:

- ✅ .NET Framework 4.7.1 Targeting Pack  
- ✅ .NET Framework 4.7.2 Targeting Pack  
- ✅ .NET Framework 4.8 SDK  
- ✅ .NET Framework 4.8 Targeting Pack  
- ✅ .NET Framework 4.8.1 Targeting Pack  

### 🛠️ Workloads to Include

- **.NET Desktop Development**  
- **.NET MAUI (Multi-platform App UI) Development** *(Optional)*

---

## 🚀 Getting Started

### Step 1: Open Oracle 11g

- Launch Oracle Database 11g  
- Click on **Application Express**  
- Default login credentials:  
  `Username: system`  
  `Password: system`

### Step 2: Create a Workspace

- After login, create a new workspace  
- Recommended beginner credentials:  
  - `Username: INSHALLL`  
  - `Password: progr@mmer`

### Step 3: Run SQL Queries

- Open your workspace  
- Open and run each query from [Queries.txt](https://github.com/user-attachments/files/19820374/Queries.txt)  
- Select a query and press `Shift + Enter` to run it

---

## 🔗 Connecting to Oracle in Visual Studio

1. Open **Visual Studio**  
2. Go to `Tools` → `Connect to Database`  
3. Select **Oracle Database**  
   ![Connection Screenshot](https://github.com/user-attachments/assets/f295133e-49ef-4650-8512-ef3dd142439a)  
4. Fill in your credentials and connect  
   ![Final Step Screenshot](https://github.com/user-attachments/assets/f12d88c9-4002-4f4d-bb08-30517992f5cd)

---

## ✅ Run the Project

Once you’ve run all queries and connected the database:

- Build and run the Visual Studio project  
- If you face any issues, fix them and submit a **Pull Request** 🙌

---

> Made with ❤️ by your development team.
