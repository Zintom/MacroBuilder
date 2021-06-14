# This is the syntax spec for Zintoms Macro Builder

## FunctionDeclaration
A function declaration[FunctionDeclaration] is defined by the word "function" followed by a space, then the name of the function,
followed by open and close brackets and then open/close curly braces, the content inside the braces is considered part of that functions
"scope" and will be executed when that function is called.

Optionally, you can also define "parameters"[FunctionParameter] in between the open and close brackets, each parameter is separated by a comma ','.
Parameters are made available to the programmer as variables defined inside the functions scope.

## Example 1:
function Example(){

}

This declares a function named "Example" with Zero parameters, additionally it has no content inside the curly braces so no code is executed when this function is called.

## Example 2:
function Example(key){

}

This declares a function named "Example" with One parameter, a variable named "key", as per the previous example, the function has no content inside the curly braces so no code is executed when this function is called.