### Template generator using a template (T4) to create enum
- Base name for the template is the table name to create enum for.
- Change columnId field to the name of the field to represent the enum member numeric value
- Change columnName to the name which will become the enum member name
- Change columnDescription for a descriptive column or simply point back to the value for columnName
- Change connection string field to match your database table.

See also [Design time code generation using T4 Text Templates](https://docs.microsoft.com/en-us/visualstudio/modeling/design-time-code-generation-by-using-t4-text-templates?view=vs-2019).
### C# code to create enum
Does the same as T4 but is a tad primitive, must be executed at run time while T4 is at design time.