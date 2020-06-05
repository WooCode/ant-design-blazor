var gulp = require('gulp'),
    cleanCss = require('gulp-clean-css'),
    less = require('gulp-less');
var rename = require('gulp-rename');
var concat = require('gulp-concat');

gulp.task('less', function () {
    return gulp
        .src('wwwroot/css/ant-design-blazor.less')
        .pipe(less({ javascriptEnabled: true }))
        .pipe(cleanCss({ compatibility: 'ie8' }))
        .pipe(rename('ant-design-blazor.min.css'))
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('javascript', function () {
    return gulp.src(['wwwroot/js/libs/*.js', 'wwwroot/js/interop.es5.min.js'])
        .pipe(concat('ant-design-blazor.min.js'))
        .pipe(gulp.dest('./wwwroot/js/'));
});

//add more tasks to default with parallel example: gulp.parallel('less', 'scripts', 'javascript')
gulp.task('default', gulp.parallel('less', 'javascript'));