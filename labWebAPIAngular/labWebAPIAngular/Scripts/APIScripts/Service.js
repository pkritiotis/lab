app.service("APIService", function ($http) {
    this.getSuppliers = function () {
        return $http.get("api/Supplier")
    }
});