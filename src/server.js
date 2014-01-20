var express = require('express');
var app = express();
var mongoose = require('mongoose'), Schema = mongoose.Schema;


var database = require('./config/database');
mongoose.connect(database.url);

app.configure(function(){
	app.use(express.static(__dirname+'/public'));
	app.use(express.logger('dev'));
	app.use(express.bodyParser());
	app.use(express.methodOverride());
	app.set('views', __dirname+'/views');
	app.engine('html', require('ejs').renderFile);
	app.set('view engine', 'html');
});


require('./core/routes')(app);

// Start App.
app.listen(7337);
console.log("App listening on port 7337");
