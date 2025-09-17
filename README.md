# Hospital UML
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
ASSIGMENT:
"Scenario: A hospital has doctors, nurses, and patients. Doctors can prescribe treatments and medications, while nurses assist doctors and care for patients. Each patient has a medical record containing
information such as diagnosis, treatments, and previous visits. The hospital also has departments such as cardiology, neurology, etc."
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
This UML diagram shows the interconecting structures between classes (or at the very least a brief sum of the neccassary ones) that composes a Hospital system.
The classes involve:

  Hopsital (main)

  Ward
     
  Person ______ Patients ---- Journal 
  
  Person ____ Residents ______ Nurse / Doctor

## Relationships:
---------------------------------------------------
   HOPSITAL  |   COMPOSITION   |   WARD/PERSON
---------------------------------------------------
   PERSON    |     INHERIT     | PATIENT/ RESIDENT     
---------------------------------------------------
   RESIDENT  |     INHERIT     |  DOCTOR/NURSE     
---------------------------------------------------
   PATIENT   |   AGGREGATION   |    JOURNAL     
---------------------------------------------------

# Hopsital
The class in question is going to be a class that contains information on the hospital itself, when the other some of the later classes uses the Hopsital objects in their own parameters when instantiated.
This also has a few methods like Close and Open the hopsital.

## Ward
Ward is just class that creates Ward objects, they are declared with WardNumber and WardName at initation but I also made it so that the there is a static list of WardNames to choose form it Ward[] array.

## Person
Abstract base class for Patient And Residents, store basic people traits taht will be used in the hospital such as ID, Name, what Ward they belong, I didn't include any methods here. It is an abstract class
since it will never be called by itself.

### Patient
Has a few new members such as owning its own Journal (Log) where some information will be stored but also a mehtod to display its own inherit members and the Log contents.
                       
## Resident
Residents are the people working at the hopsital, they share common traits with Person class and inherits some of them with additional members of Shift (what time they work) and "Profession" for their role.
Some other job-related functions like ClockIn and ClockOut have been added for when workers head in and out of work. This class is abstract because it will already have new classes based on it.

###Nurse
Nurse has the added membebers of TeamMates (what group of nurses the ywork with) and Assigned Doctor (their main doctor to support). Most of their methods refer to either the patient or the doctor. They
can assist their doctor, look at patient records, change records, be teamed up with new nurses and of course they inherit the ClockIn and ClockOut through polymorphism.

###Doctor 
Also a derived class from the Resident class. The doctor has modified ClockIn and CLockOut as the Nurse but it also has it overy own attributes and functions. It has a patient list, a status variable depending
on if they are busy or available, they have the ability to RequestTransfers of patients to new Wards, make diagnosises, and prescribe medicine to the patient.

##Jorunal
A class containing miscellaneous infromation keep from earlier visits and the overall diagnosis for the patietn. IT also stores string logs i na log book that can be browsed.

Do
