Topics (1 of 2)

3.1 Reading Input with TextBox Controls

3.2 A First Look at Variables

3.3 Numeric Data Type and Variables

3.4 Performing Calculations

3.5 Inputting and Outputting Numeric Values

3.6 Formatting Numbers with the ToString Method

3.7 Simple Exception Handling

3.8 Using Named Constants
3.1 Reading Input with TextBox Control

__TEXTBOX 
-----------------

TextBox control

a rectangular area

can accept keyboard input
from the user

located in the Common
Control group of the
Toolbox

double click to add it to the
form

default name is textBoxn

where n is 1, 2, 3, …

The Text Property

A TextBox control’s Text property stores the user inputs

Text property accepts only string values, e.g.

textBox1.Text = "Hello";

To clear the content of a TextBox control, assign an
empty string("")

textBox1.Text = string.Empty;

textBox1.Clear();

textBox1.Text = "";

3.2 A First Look at Variables

A variable is a storage location in memory

A variable name represents the memory location

In

you must declare a variable in a program before

using it to store data

The syntax to declare variables is:

DataType VariableName;

Data Types

A

variable must be declared with a proper data type

The data type specifies the type of data a variable can hold

In

many data types are known as primitive data types

they store fundamental types of data (means essential or core

such as strings and integers

“Primitive” means basic / simple / built-in.

In C#, primitive data types are already defined by the
language, not created by you.

Variable Names

A variable name identifies a variable

Always choose a meaningful name for variables

Basic naming conventions are:

the first character must be a letter (upper or
lowercase) or an underscore (_)

the name cannot contain spaces

do not use

keywords or reserved words

String Variables

A string is a combination of characters

A variable of the string data type can hold any combination of characters,
such as names, phone numbers, and social security numbers

The value of a string variable is assigned on the right of the = operator
surrounded by a pair of double quotes:

productDescription = "Jamhuuriya University";

The following assigns the productDescription string to a Label control
named productLabel:

productLabel = productDescription;

You can also display a string variable in a Message Box:

MessageBox.Show(productDescription);

String Concatenation

Concatenation is the appending of one string to the end of another
string

In

the + operator is used for concatenation

Concatenation can happen between a string and another data type

int and string

double and string

12 + " apples";

"Total is " + 25.75;

Example of string variable demo
application

Declaring Variables Before Using Them

You can declare variables and use them later

Local Variables and Scope

A local variable belongs to the method in which it was declared

Only statements inside that method can access the variable

Scope describes the part of a program in which a variable may be accessed

Lifetime of a variable is the time period during which the variable exists in
memory while the program is executing

A local variable is created in memory when the method in which it is declared
starts executing. When the method ends, all the method’s local variables are
destroyed.

Duplicate Variable Names

You cannot declare two variables with the same name in the
same scope.

For example, if you declare a variable named productDescription in
an event handler, you cannot declare another variable with that
name in the same event handler.

You can, however, have variables of the same name declared in
different methods

Assignment Compatibility

You can assign a value to a variable only if the
value is compatible with the variable’s data type.

Only strings are compatible with the string data
type

Home Assignment

Initializing Variables

In C#, a variable must be assigned a value before it can
be used. For example, look at this code:

This code declares a string variable named productDescription and then
tries to display the variable’s value in a message box.

The only problem is that we have not assigned a value to the variable.
When we compile the application containing this code, we will get an
error message such as Use of unassigned local variable
‘productDescription’.

The C# compiler will not compile code that tries to use an unassigned
variable.

Declaring Multiple Variables with One
Statement

You can declare multiple variables of the same data type
with one declaration statement. Here is an example:

string lastName, firstName, middleName;

Remember, you can break up a long statement, so it
spreads across two or more lines. Sometimes you will see
long variable declarations written across multiple lines,
like this:

string lastName = "Khalaf",

firstName = "Mohamed",

middleName = "Abdullahi";

3.3 Numeric Data Types and Variables

If you need to store a number in a variable and use the number in a
mathematical operation, the variable must be of a numeric data type

Commonly used

numeric data types:

int: whole number in the range of

to

2,147,483,647

double: real numbers including numbers with fractional parts

decimal: real numbers, stored with greater precision than
doubles. Typically used in financial applications.

Numeric Literals

A numeric literal is a number that is written into a program’s code.

Examples of variables initialized with numeric literals:

int hoursWorked = 40;

double temperature = 87.6;

The literal value cannot be surrounded by quotes.

Integer literals such as 40,

and 99 are treated as an int.

Numeric literals with a decimal point, such as 87.6, 3.14, and 1.0, are
treated as a double.

To create a decimal literal, append the letter M or m to a numeric
literal. Example:

decimal payRate = 28.75m;

Assignment Compatibility for int Variables

You can assign int values to int variables, but you cannot
assign double or decimal values to int variables. For
example,

int hoursWorked = 40; // This works

int unitsSold = 650m; // ERROR!

int score = −25.5; // ERROR!

Assignment Compatibility for double Variables

You can assign either double or int values to double
variables, but you cannot assign decimal values to double
variables. For example,

double distance = 28.75; // This works

double speed = 75; // This works

double sales = 6500.0m; // ERROR!

Assignment Compatibility for decimal
Variables

You can assign either decimal or int values to decimal
variables, but you cannot assign double values to decimal
variables. For example,

decimal balance = 9280.73m; // This works

decimal price = 50; // This works

decimal sales = 6500.0; // ERROR!

Explicit Conversion with Cast Operators

allows you to explicitly convert among types, which is

known as type casting

You can use the cast operator which is simply the name of
the type enclosed in parentheses

int wholeNumber;

decimal moneyNumber = 4500m;

wholeNumber = (int)moneyNumber;

double realNumber;

decimal moneyNumber = 625.70m;

realNumber = (double)moneyNumber;

Declaring Local Variables with the var
Keyword

var is a keyword you can use instead of writing the full type of a variable.

The compiler automatically figures out the type from the value you assign
(this is called type inference).

You can use the var keyword to declare and initialize a local variable.
Example:

var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;

You must provide an initialization value when declaring a variable with var.

The compiler determines the variable's data type from the initialization value.

The var keyword can be used only to declare local variables (variables
declared inside a method).

Later you will see how var can simplify complex declarations.

3.4 Performing Calculations

Basic calculations such as arithmetic calculations can be
performed by math operators

Operator

Name of the operator

Description

+

Addition

Adds two numbers

Minus sign

Subtraction

Subtracts one number from another

Asterisk

Multiplication

Multiplies one number by another

Forward slash

Division

Divides one number by another and gives the
quotient

Percentage

Modulus

Divides one number by another and gives the
remainder

Rules for Performing Calculations

A math expression performs a calculation and gives a value

int x = 5, y = 4;

MessageBox.Show((x + y).ToString());

Be sure to follow the order of operations and group with parentheses if
necessary

result = (a + b) / 4;

In a calculation of mixed data types, the data type of the result is determined
by:

When an operation involves an int and a double, int is treated as
double and the result is double

When an operation involves an int and a decimal, int is treated as
decimal and the result is decimal

An operation involving a double and a decimal is not allowed.

Integer Division

When you divide an integer by an integer in

the result is always

given as an integer. The result of the following is 2.

int x = 7, y = 3;

MessageBox.Show((x / y).ToString());

This is known as integer division. To avoid it:

int x = 7, y = 3;

MessageBox.Show(((double)x / y).ToString());

double x = 7, y = 3;

MessageBox.Show((x/y).ToString());

3.5 Inputting and Outputting Numeric Values

Input collected from the keyboard are considered combinations of characters (or string literals)
even if they look like a number to you

A TextBox control reads keyboard input, such as 25.65. However, the TextBox treats it as a
string, not a number.

If the user has entered a numeric value into a TextBox control and you want to assign that
value to a numeric variable, you have to convert the control’s Text property to the desired
numeric data type. Unfortunately, you cannot use a cast operator to convert a string to a
numeric type.

In

use the following Parse methods to convert string to numeric data

types:

int.Parse

double.Parse

decimal.Parse

Examples:

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);

Example

Displaying Numeric Values

The Text property of a control only accepts string literals

To display a number in a TextBox or Label control requires you to convert a
numeric data to string type

In

all variables work with the ToString method to convert the value of

the variables to strings:

You call the ToString method using the following general format:
variableName.ToString()

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

Another option is “implicit string conversion with the + operator”:

int idNumber = 1044;

string output = "Your ID number is " + idNumber;

Home Assignment

3.6 Formatting Numbers with the
ToString Method

The ToString method can optionally format a number to appear in a
specific way

The following table lists the Format Strings and how they work with sample
outputs

Format String

Description

Number

ToString()

Result

"N" or "n"

Number format

12.3

ToString("n3")

12.300

"F" or "f"

Fixed-point scientific format

123456.0

ToString("f2")

123456.00

"E" or "e"

Exponential scientific format

123456.0

ToString("e3")

1.235e+005

"C" or "c"

Currency format

Negative 1234567.8

ToString("C")

($1,234,567.80)

"P" or "p"

Percentage format

.234

ToString("P")

23.40%

Home Assignment

3.7 Simple Exception Handling

An exception is an unexpected error that happens while a program is
running ,Exceptions = runtime errors. Example errors:

Dividing by zero

Trying to open a file that does not exist

Invalid user input

If an exception is not handled by the program, the program will abruptly
halt

What is exception handling? Exception handling is writing special code
that catches errors and tells the program what to do instead of crashing.

This code is called an exception handler.

This allows you to write code that responds to exceptions. Such code is
known as an exception handler.

Handling Exceptions with try-catch

General format of the try-catch statement:

try

{

statement;

statement;

etc.

}

catch

{

statement;

statement;

etc.

}

The try block is where you place the statements that can cause an exception

The catch block is where you place statements that respond to the exception when it
happens

Throwing an Exception

In the following example, if the user enters nonnumeric data into the
milesText control, an exception is thrown.

What is different Throwing, Catching

Throwing = raising the error (problem occurs).

Catching = handling the error (deciding what to do about it).

Real-Life Examples

ATM Machine

You enter your PIN incorrectly three times.

Throwing: The ATM raises an error ("Invalid PIN").

Catching: Instead of shutting down, the ATM shows a friendly message:
“Invalid PIN, please try again.”

Car Driving

Your car runs out of fuel while driving.

Throwing: The car has a problem (fuel is empty).

Catching: The dashboard shows a warning light instead of letting the engine
suddenly die without warning.

Displaying an Exception’s Default Message

Every exception (error) in C# is an object

That object has a property called Message which stores a description of
the error.

The Exception object's Message property holds the exception's default error
message.

You can use the following format to display the exception’s error message:

try

{

statement;

statement;

etc.

}

catch (Exception ex)

{

MessageBox.Show(ex.Message);

}

Practice with class

Solution The Code

3.8 Using Named Constants

A named constant is a name that represents a value that cannot be
changed during the program’s execution

In a constant can be declared by const keyword:

const double INTEREST_RATE = 0.129;

Writing the name of a constant in uppercase letters is traditional in
many programming languages but is not a requirement.

3.9 Declaring Variables as Fields

A field is a variable that is declared at the class level

It is declared inside the class, but not inside of any
method

A field’s scope is the entire class

In the following FieldDemo application, the name
variable is a field that is declared in the Form1 class

The name field is created in memory when the Form1
form is created

The FieldDemo Application

3.10 Using the Math Class

The .NET Math class provides several methods for performing
complex mathematical calculations

Math.Sqrt(x): returns the square root of x (a double).

Math.Pow(x, y): returns the value of x raised to the power of
y. Both x and y are double.

Math.Max(x, y): Returns the greater of the two values x and y

Math.Min(x, y):Returns the lesser of the two values x and y.

Math.Round(x) :Returns the value of x (a double or a decimal)
rounded to the nearest integer.

There are two predefined constants:

Math.PI: represents the ratio of the circumference of a circle
to its diameter.

Math.E: represents the natural logarithmic base

3.11 More G U I Details – Tab Order

When an application is running, one of the form’s controls always
has the focus

Focus means a control receives the user’s keyboard input

When a button has the focus, pressing the Enter key can
execute the button’s Click event handler

The order in which controls receive the focus is called the tab order

When the user presses the tab key to select controls, the
program will follow the tab order

The TabIndex property contains a numeric value indicating the
control’s position in the tab order

The value starts with 0. The index of first control is 0, the nth

control is

Tab Order (1 of 2)

To set the tab order of a control, click Tab Order on the
View menu. This activates the tab-order selection mode
on the form.

Simply click the controls with the mouse in the order
you want.

Notice that Label controls do not accept input from the
keyboard. They cannot receive focus.

Their TabIndex values are irrelevant

Tab Order (2 of 2)

You can use the Focus method to change the focus using the following
syntax:

ControlName.Focus();

The following changes the focus to nameTextBox when the user clicks the
Clear button:

private void clearButton_Click(object sender, EventArgs e)

{

nameTextBox.Focus();

}

Assign Keyboard Access Key to Buttons

An access key (or mnemonic) is a key that is pressed in combination
with the Alt key to quickly access a control

You can assign an access key to a button’s Text property by adding

an ampersand (&) before a letter

The user can use the keystrokes Alt + X or Alt + x.

An access key does not distinguish between uppercase and
lowercase

Setting Colors

Forms and most controls have a BackColor property

Controls that can display Text also have a ForeColor property

These color-related properties support a drop-down list of
colors

The list has tree tabs:

Custom: display a color palette

Web: list colors displayed with consistency in Web
browsers

System: list colors defined in current Windows

You can set colors in color

The .NET Framework provides numerous values that
represent colors

messageLabel.BackColor = Color.Black;

messageLabel.ForeColor = Color.Yellow;

Background Images for Forms (1 of 2)

A Form has a property named BackgroundImage that is
similar to the Image property of a PictureBox.

Simply import an image to the Select Resource
window

A Form also has a BackgroundImageLayout property
that is similar to the SizeMode property of a PictureBox.

Choose from one of the following options

Background Images for Forms (2 of 2)

GroupBoxes versus Panels

A GroupBox control is a container with a thin border and an optional title that
can hold other controls

A Panel control is also a container that can hold other controls

There are several primary differences between a Panel and GroupBox:

A panel cannot display a title and does not have a Text property, but a
GroupBox supports these two properties.

A panel’s border can be specified by its BorderStyle property, while the
GroupBox cannot be

3.12 Using the Debugger to Locate Logic
Errors

A logic error is a mistake that does not prevent an application from
running, but causes the application to produce incorrect results.

Mathematical errors

Assigning a value to the wrong variable

Assigning the wrong value to a variable

etc.

Finding and fixing a logic error usually requires a bit of detective
work.

Visual Studio provides debugging tools that make locating logic
errors easier.

Breakpoints (1 of 2)

A breakpoint is a line you select in your source code.

When the application is running and it reaches a
breakpoint, the application pauses and enters break
mode.

While the application is paused, you may examine
variable contents and the values stored in certain control
properties.

Breakpoints (2 of 2)

Break Mode

In Break mode, to examine the contents of a variable or
control property, hover the cursor over the variable or the
property's name in the Code editor.