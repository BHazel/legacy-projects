Installation of Read has been set up using GNU Autotools, and as such follows the standard installation pattern:

{{
./configure
make
make install
}}
**Configuration**

By default, read is installed to the _/usr/local/bin_ directory. If you do not have sufficient permissions to install to this location, i.e. you are not _root_, the installation directory can be customised using the _--prefix_ option on configure:

{{
./configure --prefix=/location/to/install
}}
The default C compiler is the GNU C Compiler, _gcc_. This can be changed as required by setting the _CC_ variable on configure. For example, for the Intel C Compiler:

{{
./configure CC=icc
}}
Additional settings can be customised as required. To view all options, use the _--help_ option on configure:

{{
./configure --help
}}
**Installation**

Once configuration is complete, simply run the _make_ and _make install_ commands. The installed files can be found within the installation directory at:

* **Read Binary:** $INSTALLDIR/bin/read
* **Read Manual Page:** $INSTALLDIR/share/man/man1/read.1

If you have not installed Read into the _/usr/local/bin_ directory, you will need to add the directories of the Read binary and manual page to your $PATH and $MANPATH environment variables respectively.