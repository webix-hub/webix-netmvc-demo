# Webix demo for .Net MVC

This package shows how Webix can be used with .Net MVC backend.

There are 3 major cases:

- Loading data into data components (list, datatable, chart, etc. )
- Loading data in hierarchical components (tree, treetable, etc.)
- Working with forms

For data loading the server must provide a GET handler which returns a collection of JSON objects (a single JSON object in case of the form )

For data saving, a common REST pattern is used. Rest handlers must return a valid JSON object with optional ID value.

### Check also


- [PHP (Lumen | Laravel) samples](//github.com/webix-hub/webix-php-lumen-demo)
- [NodeJS (Express) samples](//github.com/webix-hub/webix-nodejs-demo)


## License

[MIT license](http://opensource.org/licenses/MIT)
