var gulp = require("gulp"),
    rimraf = require("rimraf"),
    lib = './wwwroot/lib/';

gulp.task('default', function () {
    // place code for your default task here
});

gulp.task('move:jquery', ['cleanLib'], function () {
    console.log('about to move jquery');
    gulp.src([
        'node_modules/jquery/dist/*.*'
    ]).pipe(gulp.dest(lib + 'jquery'));
});

gulp.task('move:jquery-validation', ['cleanLib'], function () {
    console.log('about to move jquery-validation');
    gulp.src([
        'node_modules/jquery-validation/dist/**/*.js'
    ]).pipe(gulp.dest(lib + 'jquery-validation'));
});

gulp.task('move:jquery-validation-unobtrusive', ['cleanLib'], function () {
    console.log('about to move jquery-validation-unobtrusive');
    gulp.src([
        'node_modules/jquery-validation-unobtrusive/*.js'
    ]).pipe(gulp.dest(lib + 'jquery-validation-unobtrusive'));
});

gulp.task('move:bootstrap', ['cleanLib'], function () {
    console.log('about to move bootstrap');
    gulp.src([
        'node_modules/bootstrap/dist/**/*.*'
    ]).pipe(gulp.dest(lib + 'bootstrap'));
});

gulp.task('moveToLib', [
    'move:bootstrap',
    'move:jquery',
    'move:jquery-validation',
    'move:jquery-validation-unobtrusive'
]);

gulp.task('cleanLib', function (cb) {
    console.log('about to clean');
    rimraf('./wwwroot/lib', cb);
});

gulp.task('loadLib', [
    'cleanLib',
    'moveToLib'
]);
