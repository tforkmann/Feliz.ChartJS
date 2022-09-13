module Docs.Pages.Install

open Feliz
open Elmish
open Feliz.DaisyUI
open Docs.SharedView

[<ReactComponent>]
let InstallView () =
    React.fragment [ Html.divClassed
                         "description"
                         [ Html.text
                               "First of all you need to install your TIA Portal and then copy the TIA Portal Openess libraries from the public API folder"
                           Html.a [ prop.className "link"
                                    prop.href
                                        "https://assets.new.siemens.com/siemens/assets/api/uuid:0fdd52a4-c384-4e55-a89d-ba9181d17fc7/tia-openness.pdf"
                                    prop.text " TIA Openness installation steps" ]
                           Html.text " and then proceed with installing "
                           Html.a [ prop.className "link"
                                    prop.href "https://www.nuget.org/packages/Clapper"
                                    prop.text "Clapper NuGet" ]
                           Html.text "." ]
                     Daisy.alert [ alert.warning
                                   prop.text
                                       "The TIA Openness API sadly is not the newest. So you have to set your Targetframework to netframework4.8." ]
                     Html.divClassed "description" [ Html.text "Using NuGet package command" ]
                     Html.divClassed
                         "max-w-xl"
                         [ Daisy.mockupCode [ Html.pre [ mockupCode.prefix "$"
                                                         prop.children [ Html.code "Install-Package Clapper" ] ] ] ]
                     Html.divClassed "description" [ Html.text "or Paket" ]
                     Html.divClassed
                         "max-w-xl"
                         [ Daisy.mockupCode [ Html.pre [ mockupCode.prefix "$"
                                                         prop.children [ Html.code "paket add Clapper" ] ] ] ]

                      ]