By default, the _less_ command is used to view Readme files, but any program can be used.

To use a different program as a default viewer, you need to create a settings file in your home directory, named _.readfile_:

{{
$(HOME)/.readfile
}}
Once created, load the file in a text editor of your choice and type the program you would like to use at the beginning of the top line, e.g. for GEdit:

{{
gedit
}}
Please note that spaces and new lines are ignored, therefore you should only use the filename of the program.

After saving and closing the file, Read should load Readme files using the program you specified in _.readfile_. To change the program at a later date, simply change the program name in _.readfile_.

**Restoring the Default Settings**

To restore _less_ as the default program, you can either:

* Remove any program name from _.readfile_, leaving it empty. When Read finds an empty _.readfile_, it defaults back to _less_.
* Remove or rename _.readfile_