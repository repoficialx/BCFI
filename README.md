# BCFI - Bar-Code Food Information 📦🍎

> Escanea o escribe el código de barras de cualquier producto alimenticio y obtén al instante toda la información clave sobre sus ingredientes, aditivos, NutriScore y más. Simple, rápido y directo, como todo lo que mola.

---

## 🚀 ¿Qué es BCFI?

BCFI es una aplicación ligera que consulta la base de datos abierta de [OpenFoodFacts](https://world.openfoodfacts.org) para mostrarte toda la información nutricional y de aditivos de un producto con solo meter su código de barras.

Olvídate de etiquetas pequeñas o confusas: con BCFI tendrás toda la info al alcance de tu mano, sin complicaciones.

---

## 📱 Cómo usar la app

1. Introduce el código de barras (UPC/EAN) en la caja de texto.
2. Pulsa el botón **Buscar**.
3. La app mostrará:
   - Nombre y marca del producto.
   - NutriScore y EcoScore (con colores para que lo entiendas fácil).
   - Lista de aditivos con su nivel de seguridad.
   - Ingredientes destacados.
   - Alérgenos relevantes.
   - Imagen del producto (si está disponible).

---

## 🎯 Características principales

- Interfaz sencilla y minimalista, perfecta para iPhone y Windows.
- Consulta instantánea vía API abierta de OpenFoodFacts.
- Resultados claros con indicadores visuales para entender la calidad nutricional.
- Manejo asíncrono para que la app no se quede congelada.
- Preparada para integrarse en ecosistemas como deneOS.

---

## 📸 Capturas de pantalla

*(Aquí incluir imágenes de la app mostrando la interfaz con resultados para un código de barras)*

---

## 💡 Consejos

- Asegúrate de que el código de barras está bien escrito (sin espacios).
- La app depende de la base de datos de OpenFoodFacts, por lo que algunos productos pueden no tener toda la información.
- Para mejores resultados, usa códigos de barras estándar EAN/UPC.

---

## 🛠️ Tecnologías usadas

- C# con .NET para la lógica y llamada a API.
- WinForms para la interfaz gráfica.
- HttpClient para consultas web asíncronas.
- JSON para parsear respuestas.

---

## 📂 Próximos pasos

- Añadir caché local para consultas frecuentes.
- Exportar información a archivos `.finfo`.
- Mejorar interfaz con colores y gráficos.
- Integrar escáner de código de barras con cámara.
- Versión para macOS y iOS con SwiftUI.

---

## 🤝 Contribuciones

¿Quieres mejorar BCFI? ¡Genial! Abre un issue o pull request y hagamos esta app aún más potente.

---

## 📄 Licencia

Este proyecto es open source bajo licencia MIT. Datos proporcionados por OpenFoodFacts.

---

¡Gracias por usar BCFI, la app que pone la información alimentaria en tus manos, al estilo Apple! 🍏📱
