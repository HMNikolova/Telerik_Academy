function solve () {
	var module = (function  () {
		//изнасям си валидацията тук, защото ще я ползвам често(по принцип це изнася в друг модул)
		var playlist,
			validator,
			audio,
			video,
			CONSTANTS = {
				TEXT_MIN_LENGTH: 3,
				TEXT_MAX_LENGTH: 25, 
				IMDB_MIN_RATING: 1,
				IMDB_MAX_RATING: 5
			},
			playable;

			validator = {
				//name - ако аз подам за име age, да гърми "age is not defined"
				//понеже minLength и maxLength са винаги 3 и 25, ги изнасям като константа
				validateIfUndefined: function (val, name) {
					name = name || 'Value';
					if (val === undefined) {
						throw new Error(name + ' cannot be undefined');
					} 
				},
				validateIfObject: function (val, name) {
					name = name || 'Value';
					if (typeof val !== 'object') {
						throw new Error(name + ' cannot be undefined');
					}
				},
				valdateIfNumber: function(val, name){
					name = name || 'Value';
					this.validateIfUndefined(val, name);
					//да валидирам дали е число
					if (typeof val!== 'number'){
						throw new Error(name + ' must be a number');
					}
				},
				validateString: function (val, name) {
					//ако продаде име да го използваме, ако не подаде да гърми default-но
					name = name || 'Value';
					//първо проверяваме като валидираме стринга, ако е undefined не е валидно
					//второ дали е стринг, ако не е стринг, не е валидно
					//третото да проверим дали дължината е м/у 3 и 25
					this.validateIfUndefined(val, name);
					if (typeof val !== 'string') {
						throw new Error(name + ' must be a string');
					}
					if (val.length < CONSTANTS.TEXT_MIN_LENGTH || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
						throw new Error(name + ' must be between' + CONSTANTS.TEXT_MIN_LENGTH + ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols');
					}
				}, 
				
				validatePositiveNumber: function(val, name) {
					name = name || 'Value';
					this.validateIfUndefined(val, name);
					this.valdateIfNumber(val, name);
					if(val <= 0){
						throw new Error(name + ' must be positive number');
					}
				},
				validateImdbRating: function(val){
					this.validateIfUndefined(val, 'IMDB Rating');
					this.valdateIfNumber(val, 'IMDB Rating');
					if(val < CONSTANTS.IMDB_MIN_RATING || CONSTANTS.IMDB_MAX_RATING < val) {
						throw new Error('IMDB Rating must be between ' + CONSTANTS.IMDB_MIN_RATING + ' and ' + CONSTANTS.IMDB_MAX_RATING);
					}
				}
			};

			playlist = (function () {
				//правим си променлива currentPlaylistId за id-то
				var currentPlaylistId = 0,
				playlist = Object.create({});
				Object.defineProperty(playlist, 'init', {
					value: function(name) {
						this.name = name;
						this._id = ++currentPlayableId;
						//тук ще добавяме всички playable-ли, които някой ми добавя
						this._playables = [];
						return this;
					}
				});
				//пропърти за name
				Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateString(val, 'Playlist name');
                    this._name = val;
                }
            });

				//добавяме и метода
				Object.defineProperty(playlist, 'addPlayable', {
					//какви валидации може да направим на playlist - първо да проверим обект ли е въобще, второ да проверим има ли id и трето дали е undefined
					value: function (playable) {
						validator.validateIfUndefined(playable, 'Playlist add playable parametar');
						validator.valdateIfObject(playable, 'Playlist add playable parametar');
						validator.validateIfUndefined(playable.id, 'Playlist add playable parametar must have id');

						this._playables.push(playable);
						return this;
					}
				});

				//54:50

				return playlist;
			}());

		playable = (function (){
			//първото нещо, което правим е да си създадем празен обект
			var currentPlayableId = 0,
				playable = Object.create({});
			//след това конструктор
			Object.defineProperty(playable, 'init', {
				//init на Playable трябва да създава title и author
				value: function (title, author){
					//закачаме ги на текущия обект
					this.title = title;
					this.author = author;
					//когато някой ни създаде нов playable, променливата(currentPlayableId) е първа за този app, и първото id ще бъде 1
					this._id = ++currentPlayableId;
					return this;	
				}
			});

			//започвам да създавам пропъртитата
			Object.defineProperty(playable, 'id', {
				//само getter защото id-то не трябва да се променя
				get: function () {
					return this._id;
				}
			});
			Object.defineProperty(playable, 'title', {
				get: function () {
					return this._title;
				},
				set: function (val) {
					validator.validateString(val, 'Playable Title');
					this._title = val;
				} 
			});
			Object.defineProperty(playable, 'author', {
				get: function () {
					return this._author;
				},
				set: function (val) {
					validator.validateString(val, 'Playable Author');
					this._author = val;
				} 
			});
			//правим си и метод play
			Object.defineProperty(playable, 'play', {
				value: function () {
					return this.id + '. ' + this.title + ' - ' + this.author;
				}
			});
			return playable;
		}());
		
		//audio трябва да наследява playable
		//тук го използвам playable като parent
		audio = (function (parent) {
			var audio = Object.create(parent);
			//казвам че искам да ми се преизползва базовия init
			Object.defineProperty(audio, 'init', {
				value: function (title, author, length) {
					parent.init.call(this, title, author);
					this.length = length;
					return this;
				}
			});
			//в условието задължително трябва да ни е положително число затова се качваме горе за да си го валидираме
			Object.defineProperty(audio, 'length', {
				get: function () {
					return this._length;
				},
				set: function (val) {
					validator.validatePositiveNumber(val, 'Audio Length');
					this._length = val;
				}
			});

			//Правим си и метода play
			Object.defineProperty(audio, 'play', {
				value: function () {
					return parent.play.call(this) + ' - ' + this.length;
				}
			});

			return audio;
			//playable подавам тук
		}(playable));

		video = (function (parent) {
			var video = Object.create(parent);

			Object.defineProperty(video, 'init', {
				value: function (title, author, imdbRating) {
					//apply-ва ни базовия конструктор
					parent.init.call(this, title, author);
					this.imdbRating = imdbRating;
					return this;
				}
			});
			Object.defineProperty(video, 'imdbRating', {
				get: function () {
					//_imdbRating за да не влиза в безкрайна рекурсия
					return this._imdbRating;
				},
				set: function (val) {
					validator.validateImdbRating(val);
					this._imdbRating = val;
				}
			});

			Object.defineProperty(video, 'play', {
				value: function () {
					return parent.play.call(this) + ' - ' + this.imdbRating;
				}
			});


			return video;
		}(playable));

		return {
			getPlayer: function (name){
		        // returns a new player instance with the provided name
		    },
		    getPlaylist: function(name){
		        //returns a new playlist instance with the provided name
		    },
		    getAudio: function(title, author, length){
		        return Object.create(audio).init(title, author, length);
		    },
		    getVideo: function(title, author, imdbRating){
		        return Object.create(video).init(title, author, imdbRating);
		    }
		};
	}());
	return module;
}
var module = solve();
for(var i = 1; i <= 10; i++) {
	var currentAudio = module.getAudio('Audio' + i, 'Author ' + i, i);
	console.log(currentAudio.play());
}

for (var i = 0; i < 10; i++){
	var currentVideo = module.getVideo('Video ' + i, 'Author ' + i, 3.5);
	console.log(currentVideo.play());
}