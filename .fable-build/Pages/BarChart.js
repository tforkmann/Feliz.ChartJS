import { Interop_reactApi } from "../fable_modules/Feliz.1.68.0/Interop.fs.js";
import { bar } from "../fable_modules/Feliz.ChartJS.0.2.7/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.3.7.18/Util.js";
import { createElement } from "react";
import * as react from "react";
import { keyValueList } from "../fable_modules/fable-library.3.7.18/MapUtil.js";
import { Interop_reactApi as Interop_reactApi_1 } from "../fable_modules/Feliz.1.68.0/Interop.fs.js";
import { fixDocsView, codedView } from "../SharedView.js";
import { ofArray } from "../fable_modules/fable-library.3.7.18/List.js";

export function ChartJSBarChart() {
    const props_12 = [["options", {
        responsive: true,
        scales: {
            x: {
                stacked: true,
            },
            y: {
                stacked: true,
            },
        },
        plugins: {
            legend: {
                position: "top",
            },
            title: {
                display: true,
                text: "Chart.js Bar Chart",
            },
            datalabels: {
                display: true,
                allign: "bottom",
                borderRadius: 3,
                color: "red",
                backgroundColor: "green",
            },
        },
    }], ["data", {
        labels: ["January", "Feburary"],
        datasets: [{
            label: "My First Dataset",
            borderColor: "blue",
            backgroundColor: "rgba(53, 162, 235, 0.5)",
            borderSkipped: false,
            borderWidth: 2,
            borderRadius: 50,
            data: ["1", "2"],
        }, {
            label: "My Second Dataset",
            borderColor: "green",
            backgroundColor: "rgba(53, 162, 235, 0.5)",
            borderSkipped: false,
            borderWidth: 2,
            borderRadius: 50,
            data: ["1", "2"],
        }],
    }]];
    return Interop_reactApi.createElement(bar, createObj(props_12));
}

export const ChartJSChart = (() => {
    const props = [["style", {
        height: 800,
    }]];
    const children = [createElement(ChartJSBarChart, null)];
    return react.createElement("div", keyValueList(props, 1), ...children);
})();

export const title = "Line Chart";

export const code = "\n    ChartJS.bar [\n        bar.options [\n            option.responsive true\n            option.scales [\n                scale.x [ axes.stacked true ]\n                scale.y [ axes.stacked true ]\n            ]\n            option.plugins [\n                plugin.legend [ legend.position Top ]\n                plugin.title [\n                    title.display true\n                    title.text \"Chart.js Bar Chart\"\n                ]\n                plugin.datalabels [\n                    datalabels.display true\n                    datalabels.allign Bottom\n                    datalabels.borderRadius 3\n                    datalabels.color \"red\"\n                    datalabels.backgroundColor \"green\"\n                    // datalabels.labels [\n                    //     labels.value {|color=\"blue\"|}\n                    // ]\n                    // datalabels.formatter renderCustomLabel\n                    ]\n            ]\n        ]\n        bar.data [\n            barData.labels [|\n                \"January\"\n                \"Feburary\"\n            |]\n            barData.datasets [|\n                barData.dataset [\n                    barDataSet.label \"My First Dataset\"\n                    barDataSet.borderColor \"blue\"\n                    barDataSet.backgroundColor \"rgba(53, 162, 235, 0.5)\"\n                    barDataSet.borderSkipped false\n                    barDataSet.borderWidth 2\n                    barDataSet.borderRadius 50\n                    barDataSet.data [| \"1\"; \"2\" |]\n                ]\n                barData.dataset [\n                    barDataSet.label \"My Second Dataset\"\n                    barDataSet.borderColor \"green\"\n                    barDataSet.backgroundColor \"rgba(53, 162, 235, 0.5)\"\n                    barDataSet.borderSkipped false\n                    barDataSet.borderWidth 2\n                    barDataSet.borderRadius 50\n                    barDataSet.data [| \"1\"; \"2\" |]\n                ]\n            |]\n        ]\n    ]\n    ";

export function BarChartView() {
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

