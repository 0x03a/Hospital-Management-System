[Queries.txt](https://github.com/user-attachments/files/19820374/Queries.txt)# Hospital-Management-System

short project Description:

dependencies:
Visualstudio 2022 community version, upto 2019
Oracle data base 11g (mandatory)
this is the link for downloading oracle 11g: https://www.oracle.com/database/technologies/xe-prior-release-downloads.html
download it Oracle.VsDevTools.17.0 ( this is for Visualstudio 2022 community version)
if like you have 2019 just search Oracle.VsDevTools for  Visualstudio 2019

also in your visual studio 2022 or any other version upto 2019 all must have 
.NET Version install init for visual studio 


Prerequisites: .NET Framework Installation for Visual Studio 2022
To run and build this project with Oracle Developer Tools integration, make sure the following .NET Framework packs are installed in Visual Studio 2022:

✔ Required Components (select these in Visual Studio Installer):
 .NET Framework 4.7.1 targeting pack

 .NET Framework 4.7.2 targeting pack

 .NET Framework 4.8 SDK

 .NET Framework 4.8 targeting pack

 .NET Framework 4.8.1 targeting pack

📌 You don't need to install the SDKs or targeting packs for older versions like 4.7.0 or 4.7.1 SDK unless your specific project requires them.

 .NET desktop development
Build WPF, Windows Forms, and console apps using C#, Visual Basic, and F# with .NET and .NET Framework.

 .NET Multi-platform App UI development (MAUI)
Build Android, iOS, Windows, and Mac apps from a single codebase using C# and .NET MAUI.


After installing all these follow these steps:
step1 open oracle 11g :
![image](https://github.com/user-attachments/assets/9965287a-6054-4852-8d51-b690652a0900)

step2: After you open it click on Application Express
bydefault enter 
username:system
Password:system

step3: This interface below will open up then make your own workspace by folling the steps.
![image](https://github.com/user-attachments/assets/7a418d46-4b50-4b8e-9b32-a608f6ec6cb5)
Then create workspace.
Recommed to make workspace with  (if no basic knowledge about it): 
username: INSHALLL
password: progr@mmer
Now your work space has been created.
login init and one by run all the queries
given below:


[Upl

// Patient Queries

- First Creating table of Patient
-- Create sequence for auto-incrementing ID
CREATE SEQUENCE ID
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

-- Create PATIENT table
CREATE TABLE PATIENT (
  ID NUMBER PRIMARY KEY,
  NAME VARCHAR2(100) NOT NULL,
  PASSWORD VARCHAR2(100) NOT NULL,
  EMAIL VARCHAR2(100) NOT NULL,
  BLOODGROUP VARCHAR2(10) NOT NULL,
  GENDER VARCHAR2(10) NOT NULL,
  ADDRESS VARCHAR2(200) NOT NULL,
  CNIC VARCHAR2(16) NOT NULL
);

-- Create index on NAME for faster lookups
CREATE INDEX IDX_PATIENT_NAME ON PATIENT(NAME);

-- Create index on EMAIL for faster lookups
CREATE INDEX IDX_PATIENT_EMAIL ON PATIENT(EMAIL);

-- Create unique constraint on CNIC to prevent duplicates
ALTER TABLE PATIENT ADD CONSTRAINT UQ_PATIENT_CNIC UNIQUE (CNIC);

-- Optional: Add comments to document the table and columns
COMMENT ON TABLE PATIENT IS 'Stores patient information for hospital management system';
COMMENT ON COLUMN PATIENT.ID IS 'Unique identifier for patients';
COMMENT ON COLUMN PATIENT.NAME IS 'Full name of the patient';
COMMENT ON COLUMN PATIENT.PASSWORD IS 'Password for patient login';
COMMENT ON COLUMN PATIENT.EMAIL IS 'Email address for communication and verification';
COMMENT ON COLUMN PATIENT.BLOODGROUP IS 'Blood group of the patient';
COMMENT ON COLUMN PATIENT.GENDER IS 'Gender of the patient (Male/Female)';
COMMENT ON COLUMN PATIENT.ADDRESS IS 'Residential address of the patient';
COMMENT ON COLUMN PATIENT.CNIC IS 'National ID card number in format XXXXX-XXXXXXXX-X';




// DOCTOR 
-- Create DOCTORS table
CREATE TABLE DOCTORS (
  ID NUMBER PRIMARY KEY,
  NAME VARCHAR2(100) NOT NULL,
  PASSWORD VARCHAR2(100) NOT NULL,
  EMAIL VARCHAR2(100) NOT NULL,
  QUALIFICATION VARCHAR2(100) NOT NULL,
  GENDER VARCHAR2(10) NOT NULL,
  SALARY VARCHAR2(20) NOT NULL
);


CREATE SEQUENCE DOC_ID
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;





-- APPOINTMENT table
CREATE TABLE APPOINTMENT (
  A_ID NUMBER PRIMARY KEY,
  PATIENT_ID NUMBER NOT NULL,
  S_TIME VARCHAR2(20) NOT NULL,
  E_TIME VARCHAR2(20) NOT NULL,
  STATUS VARCHAR2(20) NOT NULL,
  A_DATE DATE NOT NULL,
  FEE NUMBER NOT NULL,
  DISEASE VARCHAR2(200) NOT NULL,
  DOCTOR_NAME VARCHAR2(100) NOT NULL,
  
  CONSTRAINT FK_APPOINTMENT_PATIENT FOREIGN KEY (PATIENT_ID) 
    REFERENCES PATIENT(ID),
  
  CONSTRAINT CHK_APPOINTMENT_STATUS CHECK 
    (STATUS IN ('PENDING', 'APPROVED', 'CANCELLED', 'COMPLETED'))
);

--NURSE table


-- Create sequence for auto-incrementing nurse IDs
CREATE SEQUENCE NURSE_ID
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

-- Create NURSE table with all constraints
CREATE TABLE NURSE (
  ID NUMBER PRIMARY KEY,
  NAME VARCHAR2(100) NOT NULL,
  PASSWORD VARCHAR2(100) NOT NULL,
  EMAIL VARCHAR2(100) NOT NULL,
  QUALIFICATION VARCHAR2(100) NOT NULL,
  GENDER VARCHAR2(10) NOT NULL,
  SALARY VARCHAR2(20) NOT NULL,
  
  -- Check constraints
  CONSTRAINT CHK_NURSE_GENDER CHECK (GENDER IN ('Male', 'Female'))
);

-- Create unique constraint on NAME (as per your duplicate check logic)
ALTER TABLE NURSE ADD CONSTRAINT UQ_NURSE_NAME UNIQUE (NAME);

-- Create index on EMAIL for faster lookups
CREATE INDEX IDX_NURSE_EMAIL ON NURSE(EMAIL);



//RECEPTIONIST TABLE


-- Create sequence for auto-incrementing receptionist IDs
CREATE SEQUENCE RECEPTIONIST_ID
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

-- Create RECEPTIONIST table with all constraints
CREATE TABLE RECEPTIONIST (
  ID NUMBER PRIMARY KEY,
  NAME VARCHAR2(100) NOT NULL,
  PASSWORD VARCHAR2(100) NOT NULL,
  EMAIL VARCHAR2(100) NOT NULL,
  QUALIFICATION VARCHAR2(100) NOT NULL,
  GENDER VARCHAR2(10) NOT NULL,
  SALARY VARCHAR2(20) NOT NULL,
  
  -- Check constraints
  CONSTRAINT CHK_RECEPTIONIST_GENDER CHECK (GENDER IN ('Male', 'Female'))
);


-- Create index on EMAIL for faster lookups
CREATE INDEX IDX_RECEPTIONIST_EMAIL ON RECEPTIONIST(EMAIL);


// SCHEDULE

-- Create sequence for auto-incrementing schedule IDs
CREATE SEQUENCE S_ID
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

-- Create SCHEDULE table with all constraints
CREATE TABLE SCHEDULE (
  S_ID NUMBER PRIMARY KEY,
  S_TIME VARCHAR2(20) NOT NULL,
  E_TIME VARCHAR2(20) NOT NULL,
  DAY VARCHAR2(10) NOT NULL,
  DOCTOR_ID NUMBER NOT NULL,
  
  -- Foreign key to DOCTORS table
  CONSTRAINT FK_SCHEDULE_DOCTOR FOREIGN KEY (DOCTOR_ID) 
    REFERENCES DOCTORS(ID),
  
  -- Check constraints
  CONSTRAINT CHK_SCHEDULE_DAY CHECK (DAY IN (
    'Monday', 'Tuesday', 'Wednesday', 
    'Thursday', 'Friday', 'Saturday', 'Sunday'
  ))
);

-- Create index on DOCTOR_ID for faster lookups
CREATE INDEX IDX_SCHEDULE_DOCTOR ON SCHEDULE(DOCTOR_ID);

-- Create index on DAY for day-based queries
CREATE INDEX IDX_SCHEDULE_DAY ON SCHEDULE(DAY);







-- Note => first run all the queries after that run the project. (Mandatory)
oading Queries.txt…]()






first select a query then press shift+enter

