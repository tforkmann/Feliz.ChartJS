import { Interop_reactApi } from "../fable_modules/Feliz.1.64.0/Interop.fs.js";
import { line } from "../fable_modules/Feliz.ChartJS.0.2.5/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.3.7.18/Util.js";
import { createElement } from "react";
import * as react from "react";
import { keyValueList } from "../fable_modules/fable-library.3.7.18/MapUtil.js";
import { Interop_reactApi as Interop_reactApi_1 } from "../fable_modules/Feliz.1.64.0/Interop.fs.js";
import { fixDocsView, codedView } from "../SharedView.js";
import { ofArray } from "../fable_modules/fable-library.3.7.18/List.js";

export function ChartJSLineChart() {
    const props_7 = [["options", {
        responsive: true,
        plugins: {
            datalabels: {
                display: true,
                allign: "bottom",
                borderRadius: 3,
                color: "red",
                backgroundColor: "green",
            },
        },
    }], ["data", {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: "My First Dataset",
            borderColor: "rgb(53, 162, 235)",
            backgroundColor: "rgba(53, 162, 235, 0.5)",
            data: ["1", "2", "3", "4", "5", "6"],
        }, {
            label: "My Second Dataset",
            borderColor: "yellow",
            backgroundColor: "rgba(53, 162, 235, 0.5)",
            data: ["1", "2", "3", "4", "4", "6"],
        }],
    }]];
    return Interop_reactApi.createElement(line, createObj(props_7));
}

export const ChartJSChart = (() => {
    const props = [["style", {
        height: 800,
    }]];
    const children = [createElement(ChartJSLineChart, null)];
    return react.createElement("div", keyValueList(props, 1), ...children);
})();

export const title = "Line Chart";

export const code = "\n    ChartJS.line [\n        line.options [\n            option.responsive true\n            option.plugins[plugin.datalabels [\n                               datalabels.display true\n                               datalabels.allign Bottom\n                               datalabels.borderRadius 3\n                               datalabels.color \"red\"\n                               datalabels.backgroundColor \"green\"\n                               ]]\n        ]\n        line.data [\n            lineData.labels [|\n                \"Red\"\n                \"Blue\"\n                \"Yellow\"\n                \"Green\"\n                \"Purple\"\n                \"Orange\"\n            |]\n            lineData.datasets [|\n                lineData.dataset [\n                    lineDataSet.label \"My First Dataset\"\n                    lineDataSet.borderColor \"rgb(53, 162, 235)\"\n                    lineDataSet.backgroundColor \"rgba(53, 162, 235, 0.5)\"\n                    lineDataSet.data [|\n                        \"1\"\n                        \"2\"\n                        \"3\"\n                        \"4\"\n                        \"5\"\n                        \"6\"\n                    |]\n                ]\n                lineData.dataset [\n                    lineDataSet.label \"My Second Dataset\"\n                    lineDataSet.borderColor \"yellow\"\n                    lineDataSet.backgroundColor \"rgba(53, 162, 235, 0.5)\"\n                    lineDataSet.data [|\n                        \"1\"\n                        \"2\"\n                        \"3\"\n                        \"4\"\n                        \"4\"\n                        \"6\"\n                    |]\n                ]\n            |]\n        ]\n    ]\n    ";

export function LineChartView() {
    let elms_1;
    const children_2 = ofArray([createElement("h1", {
        className: "title is-1",
        children: Interop_reactApi_1.Children.toArray(["Feliz.ChartJS Example"]),
    }), (elms_1 = ofArray([createElement("p", {
        children: ["Here is an example how to use ChartJS"],
    }), codedView(title, code, ChartJSChart)]), createElement("div", {
        className: "content",
        children: Interop_reactApi_1.Children.toArray(Array.from(elms_1)),
    })), fixDocsView("LineChart", false)]);
    return createElement("div", {
        children: Interop_reactApi_1.Children.toArray(Array.from(children_2)),
    });
}

