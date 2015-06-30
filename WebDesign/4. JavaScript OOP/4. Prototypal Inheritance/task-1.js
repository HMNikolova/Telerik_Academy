/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */
function solve() {

	var domElement = (function () {

		var domElement = {
			init: function (type) {
				validateInput(type);

				this.type = type;
				this.parent;
				this.content = '';
				this.children = [];
				this.attributes = {};

				return this;
			},
			appendChild: function (child) {

				this.children.push(child);

				if (typeof child === 'object') {
					child.parent = this;
				}

				return this;
			},
			addAttribute: function (name, value) {
				validateInput(name);

				this.attributes[name] = value;

				return this;
			},
			removeAttribute: function(attribute){

				checkIfAttributeExist(this, attribute);

				delete this.attributes[attribute];

				return this;
			},
			get innerHTML() {

				var resultAsString = [],
					child,
					i,
					len;

				resultAsString.push('<' + this.type);

				resultAsString.push(addAttributesToResult(this));

				resultAsString.push('>');

				for (i = 0, len = this.children.length; i < len; i += 1) {
					child = this.children[i];

					if (typeof child === 'string') {
						resultAsString.push(child);
					} else {
						resultAsString.push(child.innerHTML);
					}
				}

				if (!this.children.length) {
					resultAsString.push(this.content);
				} else {
					resultAsString.push('');
				}

				resultAsString.push('</' + this.type + '>');

				return resultAsString.join('');
			}
		};

		function checkIfAttributeExist(object, attribute) {

			if (!object.attributes.hasOwnProperty(attribute)) {
				throw {message: 'This attribute does not exist'};
			}
		}

		function addAttributesToResult(object) {

			var attributeAsString = '',
				prop,
				i,
				len,
				sortable = [];

			for (prop in object.attributes) {
				sortable.push([prop, object.attributes[prop]]);
			}

			sortable = sortable.sort(function (first, second) {
				return first[0] > second[0] ? 1 : -1;
			});

			for (i = 0, len = sortable.length; i < len; i += 1) {
				attributeAsString += ' ' + sortable[i][0] + '="' + sortable[i][1] + '"';
			}

			return attributeAsString;

		}

		function validateInput(input) {

			var pattern = /[^A-Za-z0-9-]/;

			if (!input) {
				throw {message: 'You need to pass a parameter'};
			}

			if (typeof input !== 'string') {
				throw {message: 'You need to pass a string as parameter'};
			}

			if (pattern.test(input)) {
				throw {message: 'Input must contain only Latin letters'};
			}
		}

		return domElement;
	}());

	return domElement;
}
module.exports = solve;

/* Example
 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');
 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)
 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');
 div.content = 'Hello, world!';
 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');
 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);
 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */