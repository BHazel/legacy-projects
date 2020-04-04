/*
   READ v1.0.5.34
   Benedict W. Hazel
   1st April 2011
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define READ_VERSION "1.0.5.34"
#define READ_COPYRIGHT "(c) Benedict W. Hazel, 2011"
#define READ_OPEN_SOURCE "This is free software, released under the GNU Lesser General Public License (LGPL)"

FILE* readmeFile;
FILE* settingsFile;
char* readmeFilenames[] = { "readme.txt", "README.txt", "README", "readme", "Readfile", "readfile" };
char* readmeViewers[] = { "less", "emacs", "more", "vim" };
char* readmeViewer;
char* settingsReadmeViewer;
char* readmeCommand;
char* settingsPath;
int i, file, viewer, customViewerFlagLength, systemReturn;
size_t viewerAllocSize, commandAllocSize, settingsPathAllocSize;

int main(int argc, char* argv[])
{
	viewer = -1;

	// Command-line Arguments
	if (argc > 1)
	{
		if ((strcmp(argv[1], "-v") == 0) || (strcmp(argv[1], "--version") == 0))
		{
			printf("Read %s\n", READ_VERSION);
			printf("%s\n", READ_COPYRIGHT);
			printf("%s\n", READ_OPEN_SOURCE);
			return 0;
		}
		else if ((strcmp(argv[1], "-e") == 0) || (strcmp(argv[1], "--emacs") == 0))
		{
			viewer = 1;
		}
		else if ((strcmp(argv[1], "-i") == 0) || (strcmp(argv[1], "--vim") == 0))
		{
			viewer = 3;
		}
		else if ((strcmp(argv[1], "-l") == 0) || strcmp(argv[1], "--less") == 0)
		{
			viewer = 0;
		}
		else if ((strcmp(argv[1], "-m") == 0) || (strcmp(argv[1], "--more") == 0))
		{
			viewer = 2;
		}
		else if ((strncmp(argv[1], "-L", 2) == 0) || (strncmp(argv[1], "--load-with=", 12) == 0))
		{
			viewer = -2;
			if ((strncmp(argv[1], "-L", 2) == 0))
			{
				customViewerFlagLength = 2;
			}
			else if ((strncmp(argv[1], "--load-with=", 12) == 0))
			{
				customViewerFlagLength = 12;
			}
			viewerAllocSize = strlen(argv[1] + customViewerFlagLength);
			if (viewerAllocSize == 0)
			{
				viewer = 0;
			}
		}
	}
	else
	{
		settingsPathAllocSize = strlen("HOME") + 10;
		settingsPath = (char*)calloc(settingsPathAllocSize, sizeof(char));
		settingsPath = getenv("HOME");
		strcat(settingsPath, "/.readfile");
		settingsFile = fopen(settingsPath, "r");
		if (settingsFile != NULL)
		{
			settingsReadmeViewer = (char*)calloc(12, sizeof(char));
			fscanf(settingsFile, "%s", settingsReadmeViewer);
			if (strcmp(settingsReadmeViewer, "less") == 0) viewer = 0;
			else if (strcmp(settingsReadmeViewer, "emacs") == 0) viewer = 1;
			else if (strcmp(settingsReadmeViewer, "more") == 0) viewer = 2;
			else if (strcmp(settingsReadmeViewer, "vim") == 0) viewer = 3;
			else
			{
				viewer = -3;
				viewerAllocSize = strlen(settingsReadmeViewer);
				if (viewerAllocSize == 0) viewer = 0;
			}
			fclose(settingsFile);
		}
	}

	// Is a viewer already selected?
	if (viewer == -1)
	{
		viewer = 0;
	}

	if (viewer >= 0)
	{
		viewerAllocSize = strlen(readmeViewers[viewer]);
	}
	readmeViewer = (char*)calloc(viewerAllocSize, sizeof(char));

	if (viewer >= 0)
	{
		strcpy(readmeViewer, readmeViewers[viewer]);
	}
	else if (viewer == -2)
	{
		strcpy(readmeViewer, argv[1] + customViewerFlagLength);
	}
	else if (viewer == -3)
	{
		strcpy(readmeViewer, settingsReadmeViewer);
	}

	// Find Readme File
	for (i = 0; i < 6; i++)
	{
		readmeFile = fopen(readmeFilenames[i], "r");
		if (readmeFile != NULL)
		{
			file = i;
			break;
		}
		else continue;
	}
	
	// Has Readme been found?
	if (readmeFile == NULL)
	{
		// No - Close Program
		fprintf(stderr, "read: *** No valid readme found.  Stop.\n");
		return 1;
	}
	else
	{
		// Yes - Build system command and execute
		commandAllocSize = strlen(readmeViewer) + strlen(readmeFilenames[file]) + 1;
		readmeCommand = (char*)calloc(commandAllocSize, sizeof(char));
		strcat(readmeCommand, readmeViewer);
		strcat(readmeCommand, " ");
		strcat(readmeCommand, readmeFilenames[file]);
		systemReturn = system(readmeCommand);
		printf("read[%d]: Leaving file `%s'\n", systemReturn, readmeFilenames[file]);
		fclose(readmeFile);
		if (settingsReadmeViewer != NULL)
		{
			free(settingsReadmeViewer);
		}
		free(readmeCommand);
		free(readmeViewer);
		return 0;
	}
}
