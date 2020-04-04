// <copyright file="Gruntfile.js" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Gruntfile: Script for the Grunt build tasks.
// </summary>

/// <summary>
/// Grunt build tasks.
/// </summary>
/// <param name="grunt">The Grunt component.</param>
module.exports = function(grunt) {
	grunt.loadNpmTasks("grunt-typescript");

	grunt.initConfig({
		pkg: grunt.file.readJSON("package.json"),
		typescript: {
			modular: {
				src: ["src/*.ts"],
				dest: "build",
				options: {
					basePath: "src"
				}
			},
			single: {
				src: ["src/*.ts"],
				dest: "build/farrago.js",
				options: {
					basePath: "src"
				}
			}
		}
	});

	grunt.registerTask("default", ["typescript:single"]);
	grunt.registerTask("single", ["default"]);
	grunt.registerTask("modular", ["typescript:modular"]);
}