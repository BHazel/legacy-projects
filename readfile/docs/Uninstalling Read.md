As with the installation, standard GNU Autotools uninstallation commands apply:

{{
make clean
make distclean
}}
* **make clean** will remove binary and object files but will retain the Makefile, thus also retaining the configuration.
* **make distclean** will perform the same action as _make clean_ but will also remove the Makefile, thus removing all configuration customisations. Re-run _configure_ to generate the Makefile.

Any additions to the $PATH and/or $MANPATH environment variables will need to be removed.