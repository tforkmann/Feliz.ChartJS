module Views.ExampleGrid

open Fable.React
open Browser.Dom
open Feliz
open Feliz.Bulma
open Feliz.ReactJS
open Shared

let layouts =
    [|  ReactJS.layout [
                layout.i "a"
                layout.x 0
                layout.y 0
                layout.w 1
                layout.h 2
                layout.``static`` true
            ]
        ReactJS.layout [
            layout.i "b"
            layout.x 1
            layout.y 0
            layout.w 3
            layout.h 2
            layout.minW 2
            layout.maxW 4
        ] |]
[<ReactComponent>]
let ReactJSChart () =
    ReactJS.gridChart [
            ReactJS.layoutElements layouts
            ReactJS.className "layout"
            ReactJS.cols 24
            ReactJS.autoSize false
            ReactJS.isDraggable true
            ReactJS.compactType Vertical
            ReactJS.rowHeight 30
            ReactJS.onLayoutChange (fun layout ->
                console.log layout
                for e in layout do
                    console.log e.x
                    console.log e.y
                    console.log e.i
                    console.log e.w
                    console.log e.h)
            ReactJS.width 1200
            ReactJS.children [
                Html.div [
                    prop.key "a"
                    prop.text "Texta"
                ]
                Html.div [
                    prop.key "b"
                    prop.text "Textb"
                ]
                Html.div [
                    prop.key "c"
                    prop.text "Textc"
                ]
                Html.div [
                    prop.key "d"
                    prop.text "Textd"
                ]
                Html.div [
                    prop.key "e"
                    prop.text "TextE"
                ]

            ]
        ]
let ReactJSChart =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ReactJSChart ()
    ]

let overview =
    Html.div
        [ Bulma.title.h1 [ Html.text "Feliz.ReactJS Example" ]
          Bulma.content
              [ Html.p "Here is an example how to use ReactJS"
                div [ Props.Style [ Props.CSSProp.Height 350 ] ] [
                    ReactJSChart ()
                ]
                code """
                let layouts =
                    [|  ReactJS.layout [
                                layout.i "a"
                                layout.x 0
                                layout.y 0
                                layout.w 1
                                layout.h 2
                                layout.``static`` true
                            ]
                        ReactJS.layout [
                            layout.i "b"
                            layout.x 1
                            layout.y 0
                            layout.w 3
                            layout.h 2
                            layout.minW 2
                            layout.maxW 4
                        ] |]
                [<ReactComponent>]
                let ReactJSChart () =
                    ReactJS.gridChart [
                            ReactJS.layoutElements layouts
                            ReactJS.className "layout"
                            ReactJS.cols 24
                            ReactJS.autoSize false
                            ReactJS.isDraggable true
                            ReactJS.compactType Vertical
                            ReactJS.rowHeight 30
                            ReactJS.onLayoutChange (fun layout ->
                                console.log layout
                                for e in layout do
                                    console.log e.x
                                    console.log e.y
                                    console.log e.i
                                    console.log e.w
                                    console.log e.h)
                            ReactJS.width 1200
                            ReactJS.children [
                                Html.div [
                                    prop.key "a"
                                    prop.text "Texta"
                                ]
                                Html.div [
                                    prop.key "b"
                                    prop.text "Textb"
                                ]
                                Html.div [
                                    prop.key "c"
                                    prop.text "Textc"
                                ]
                                Html.div [
                                    prop.key "d"
                                    prop.text "Textd"
                                ]
                                Html.div [
                                    prop.key "e"
                                    prop.text "TextE"
                                ]

                            ]
                        ]
                """ ]
          fixDocsView "FelizReactJS.ExampleGrid" false      ]