**Invoking Read**

Read is used via the command-line and is invoked by simply calling its name:

{{
read
}}
If a valid readme file is found in the present directory, Read will load it, by default, using the _less_ command. Once the readme file has been closed, Read prints the following to standard output:

{{
read[0](0): Leaving file `FILENAME'
}}
FILENAME is the filename of the readme file loaded using Read. The 0 in square brackets corresponds to the integer value returned to the system when the program used to load a readme file closes. If a value other than 0 is shown, an error will most likely have occurred.

If no file is found in the current directory, the following is output to standard error:

{{
read: *** No valid readme found.  Stop.
}}
**Option Flags**

Read can be controlled using option flags. Primarily this is used to change which program is used to view the readme file. To use options, simply add the necessary flag after the read command:

{{
read [OPTION](OPTION)
}}
|| Option Flag(s) || Action
| -e, --emacs | Load readme file using GNU Emacs |
| -i, --vim | Load readme file using Vim |
| -l, --less | Load readme file using Less |
| -L_program_, --load-with=_program_ | Load readme file using custom _program_, e.g. _cat_ |
| -m, --more | Load readme file using More |
| -v, --version | Display version information |