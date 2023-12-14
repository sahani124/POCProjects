module.exports = function (grunt) {
    // load task
    grunt.loadNpmTasks('grunt-shell');
    // init config
    mapping = grunt.file.readJSON('appsettings.json');

    grunt.initConfig({
        shell: {
            command: ["cd C:\\Users\\Dell\\source\\repos\\CustomerProjectCore\\CustomerProjectCore\\wwwroot\\CustomerApp",
                "ng build --deploy-url=/CustomerApp/dist/CustomerApp/ --watch"].join('&&')
        }
    });

    // default task to execute
    grunt.registerTask('ngbuild', ['shell']);
};