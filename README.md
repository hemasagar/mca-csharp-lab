#**VTU MCA 5th Sem .NET Lab(13MCA57)**
   
1. Student Details Windows Application.
      1. Consider the Database STUDENT consisting of following tables: tbl_Course (CourseID:
         int, CourseName: string) tbl_Student (USN: string, StudName: string, Address: string,
         CourseID: int, YrOfAdmsn: int)
         Develop suitable windows application using C#.NET having following options:
         1. Entering new course details.
         2. Entering new student details.
         3. Display the details of students (in a Grid) who belong to a particular course
         4. Display the details the students who have taken admission in a particular year
    
2. Blood Bank Windows Application.
       2. Consider the Database BLOODBANK consisting of following tables: tbl_BloodGroup (
	  BloodID: int, BloodGroup: string) tbl_Donor (DonorID: int, DonorName: stirng, Address:
	  string, ContactNo: int, DOB: date, Gender: string, Weight: int, BloodID: int)
	  Develop suitable windows application using C#.NET having following options:   
	  1. Entering Blood group details.
	  2. Entering new donor details.
	  3. Display the details of donors (in a Grid) having particular blood group.
	  4. Display the details of donors (in a Grid) based on gender.
	  5. Display the details of donors (in a Grid) based on age (above 18), weight (above 45KG)
	     and Gender(user’s choice).  
	     
4.  Develop a Web Application using C#.NET and ASP.NET for an educational institution.
	4. The master page should consist of Institution Name, Logo and Address. Also, it should
	   provide hyperlinks to Departments, Facilities Available and Feedback. Each department
	   page and facilities page should be designed as static pages. The hyperlinks should navigate
	   to these static pages in the form of Content Pages associated with Master Page designed.
	   The Feedback page should have fields to enter Name, Email and Message with Submit and
	   Cancel Buttons. Database should be created to store these three data.

5. 	Develop a Web Application using C#.NET and ASP.NET for a Bank.
	5. The BANK Database should consist of following tables: tbl_Bank (BankID: int, BankName: string)
	   tbl_Branch (BranchID: int, BankID: int, BranchName: string) tbl_Account (AccountNo:
	   int, BankID: int, BranchID: int, CustomerName: string, Address: string, ContactNo: int,
	   Balance: real) (Note: AccountNo and BankID together is a composite primary key).
	   The master page of this web application should contain hyperlinks to New Bank Entry,
	   New Branch Entry (of selected Bank), New Customer Entry (based on branch and bank) and
           Report Generation. The hyperlinks should navigate to respective content pages. These
	   content pages provide the fields for respective data entry. The reports should be generated
	   (display in grid) as below:
	   1. Display all records of particular bank.
	   2. Display all records of a branch of particular bank.
	   3. The balance should be displayed for the entered account number (Bank and Branch are input through 
              ComboBox controls and Account number is input through TextBox).


*Tools : Microsoft Visual Studio 2010.*
