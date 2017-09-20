"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var FiltroPorTitulo = (function () {
    function FiltroPorTitulo() {
    }
    // o correto é transform, eu errei aqui intencionalmente para mostrar algo a seguir!
    FiltroPorTitulo.prototype.transform = function (fotos, digitado) {
        console.log(fotos); // quem deve ser filtrado
        console.log(digitado); // o que deve ser usado como filtro
        digitado = digitado.toLowerCase();
        return fotos.filter(function (foto) { return foto.titulo.toLowerCase().includes(digitado); });
    };
    FiltroPorTitulo = __decorate([
        core_1.Pipe({
            name: 'filtroPorTitulo'
        }), 
        __metadata('design:paramtypes', [])
    ], FiltroPorTitulo);
    return FiltroPorTitulo;
}());
exports.FiltroPorTitulo = FiltroPorTitulo;
//# sourceMappingURL=foto.pipe.js.map