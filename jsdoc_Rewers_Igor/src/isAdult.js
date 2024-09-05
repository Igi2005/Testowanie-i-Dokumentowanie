/**
 *@author Igor Rewers 5D
 * @description funkcja sprawdza czy osoba jest pelnoletnia
 * @param {number }age wiek danej osoby
 * @returns {boolean} zwraca true lub false
 * @throws {error} rzuca blad gdy wiek jest mniejszy od 0
 * @example
 * const res = isAdult(14)
 * console.log(res)
 * Wynik funkcji: false
 */
const isAdult = (age) =>{
    if(age < 0 ){
        throw new Error("wiek nie moze byc mniejszy od 0")
    }
    else{
        return age >= 18;
    }
}