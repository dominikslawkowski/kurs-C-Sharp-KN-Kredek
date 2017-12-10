var ViewModel = function () {
    var self = this;

    self.genres = ko.observableArray();
    self.error = ko.observable();
    self.detail = ko.observable();
    self.djs = ko.observableArray();

    
    var genresUri = '/api/genres/';
    
    //Metoda zwraca dane w typie JSON
    function ajaxHelper(uri, method, data) {
        self.error('');
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    //Metoda sprawia ze AJAX uzyskuje listę gatunków i ją udostęnia
    function getAllGenres() {
        ajaxHelper(genresUri, 'GET').done(function (data) {
            self.genres(data);
        });
    }

    //Metoda sprawia ze AJAX uzyskuje listę gatunków i ją udostęnia
    self.getGenreDetail = function (item) {
        ajaxHelper(genresUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    // Fetch the initial data.
    getAllGenres();
};

ko.applyBindings(new ViewModel());