var gulp = require('gulp'),
    cleanCss = require('gulp-clean-css'),
    less = require('gulp-less');
var rename = require('gulp-rename');

gulp.task('less', function () {
    return gulp
        .src('style/index.less')
        .pipe(less({ javascriptEnabled: true }))
        .pipe(cleanCss({ compatibility: 'ie8' }))
        .pipe(rename('documentation-styles.css'))
        .pipe(gulp.dest('wwwroot/css'));
});

//add more tasks to default with parallel example: gulp.parallel('less', 'scripts', 'javascript')
gulp.task('default', gulp.parallel('less'));