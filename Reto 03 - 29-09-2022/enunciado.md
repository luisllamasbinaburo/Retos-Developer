Reto developer 3!
:star: Adjunta tu respuesta en este hilo. Podéis resolverlo en vuestro lenguaje favorito
:calendar_spiral:  Fecha límite ** 16 octubre 2022 **

===== :notepad_spiral: Enunciado ===== 

Un amigo tuyo es un gran fanático de los Digimon. Para su cumpleaños, te gustaría hacer un lector de tarjetas con una pantalla TFT. Al acercar una tarjeta, la pantalla mostrará el Digimon elegido.

Para eso, necesitas una función que **obtenga la imagen de un Digimon a partir de su nombre**.

Buscando en Internet, has encontrado un API para Digimon (digimon-api.com), que dispone de todas las imágenes de Digimon.

La URL es la siguiente,
https://digimon-api.com/images/digimon/w/__digimon__.png


Donde,
- __digimon__ es el nombre de un Digimon

Por ejemplo https://digimon-api.com/images/digimon/w/Guilmon.png

Se pide hacer una función o pequeño script que, dado el nombre de un Digimon, descargue su imagen desde "digimon-api.com" a una carpeta local.

Fuente: propia


==== :fire:BONUS PACK ====
Para nota, quien quiera, puede ampliar con el siguiente ejercicio:

Obtener previamente la URL de la imagen del Digimon **a través del JSON devuelto por el API** según URL
        https://www.digi-api.com/api/v1/digimon/__digimon__

Por ejemplo, https://www.digi-api.com/api/v1/digimon/Guilmon resulta en el siguiente JSON,
```json
{
    "id": 543,
    "name": "Guilmon",
    "xAntibody": false,
    "images": [
        {
            "href": "https://digimon-api.com/images/digimon/w/Guilmon.png",
            "transparent": false
        }
    ],
    ...
}
```

Donde puede obtenerse la URL de la imagen en en JSON devuelto en **json / images / href**