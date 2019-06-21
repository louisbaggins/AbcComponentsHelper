# AbcComponentsHelper
Components of ABC channel
Nuget Package:

https://www.nuget.org/packages/AbcComponentsHelper/

To install the package:

PM> Install-Package AbcComponentsHelper -Version 1.0.0

### This library is implemented for the following Messaging Channels:

- Apple Business Chat
- Blip Chat

Using Examples:

PS: Almost all these examples accepts an extra/optional argument that sets the order or style of the element.

## 1. Properties of a listpicker
Channels:
Apple Business Chat

- [BaseMessage](https://developer.apple.com/documentation/businesschatapi/basemessage)
- [InteractiveData: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickermessage/interactivedata)
- [Data : (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickerdata)
- [Sections: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickersection)
- [MultipleSelection](https://developer.apple.com/documentation/businesschatapi/listpickersection)
- [Items(Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickeritem)
- [Image](https://developer.apple.com/documentation/businesschatapi/imageitem)
- [ReceivedMessage](https://developer.apple.com/documentation/businesschatapi/receivedmessage)
- [ReplyMessage](https://developer.apple.com/documentation/businesschatapi/replymessage)


## 2. Sending a listPicker

Example:

Code:
