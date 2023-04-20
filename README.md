1.  What would happen if you try to use a variable that is not in scope?
	If you try to use a variable that is not in scope Visual Studios will highlight the variable with a red underline and tell you that the variable is not found in the current context of your program.
    
2.  Describe the three As of a test:  
   A - Arrange 
	    - Arrange the proper variables and set up to test your method/class
    A - Act
	    - Call the method that you want to test or do the action you want to observe and save that result to a variable.
    A - Assert
	    - Compare the value you saved when calling the method with the expected value. 
      
3.  What is the difference between `public` and `private` access modifiers?
	- Public access modifiers make a class's property and methods accessible anywhere outside of the origin class allowing those values to be modified and retrieved. 
	- Private access modifiers make a class's property and methods outside the origin class inaccessible. You must use Getter and Setter methods within the class to get or set the value of a property. 
    
4.  A method should: (**Select all that apply**)  
    **(A) Make changes to an object**  
    **(B) Return some information about an object**  
    (C) Make changes to an object and return information about the object.  
    (D) None of the Above.
    
5.  How did you determine what to answer for the question above?
   - I highlighted A & B above. The reason I chose both A & B is because a method should have one responsibility following the Single Responsibility Principle. So a method could either make changes to an object or return some information about an object. If I had chosen C then the method would share too many responsibilities to adhere to the Single Responsibility Principle. 
