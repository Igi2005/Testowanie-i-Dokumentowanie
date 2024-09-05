/**
 * @author Igor Rewers 5D
 * @description funkcja sluzy do obliczania pola kola
 * @param {number} radius promien kola
 * @throws {error} rzuca blad, ze pole kola jest mniejsze od 0
 * @returns {number} zwraca pole kola
 * @example
 * const res = circleArea(5)
 * console.log(res)
 * Wynik funkcji: 15.7
 */
const circleArea = (radius) => {
    if (radius < 0) {
        throw new Error("radius is out of bounds");
    }
    else {
        return radius*3.14
    }
}