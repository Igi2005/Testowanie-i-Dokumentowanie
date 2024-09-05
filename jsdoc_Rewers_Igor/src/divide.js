/**
 * @author Igor Rewers 5D
 * @description funkcja divide sluzy do dzielenia 2 liczb
 * @param {number }value1 licznik
 * @param {number }value2 mianownik
 * @throws {error} rzuca blad gdy mianownik jest rowny 0
 * @returns {number} zwraca wynik dzielenia
 * @example
 * const res = divide(10,5);
 * console.log(res);
 * Wynik funkcji: 2
 */

const divide = (value1,value2) =>{
        if(value2 === 0) {
            throw new Error ("mianownik nie moze byc rowny 0")
        }
        else{
            return value1/value2
        }
}

divide(10,5)

