# REST API para envio de Email

El proposito de esta API es que pueda ser usada como un **microservicio** de un sistema mas grande para enviar emails

## Herramientas
- .Net core 6
- FluentValidation.AspNetCore

## Configuración
### Necesitas
- Cuenta de Email con 2FA y una contraseña de aplicación

Para poder desplegar/usar esta api solo debes crear un archivo **appsettings.json** en la raiz del proyecto con la estructura que muestra el archivo [appsettings.Example.json](./appsettings.Example.json)

### Modelo

Los tipos de datos que recibe el endpoint api/Email son:

```
{
  "To": string (debe ser del tipo correo)
  "subject": string,
  "content": sring
}
```