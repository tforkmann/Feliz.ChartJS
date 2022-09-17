import { Interop_reactApi } from "../fable_modules/Feliz.1.68.0/Interop.fs.js";
import { doughnut } from "../fable_modules/Feliz.ChartJS.0.2.7/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.3.7.18/Util.js";
import { createElement } from "react";
import * as react from "react";
import { keyValueList } from "../fable_modules/fable-library.3.7.18/MapUtil.js";
import { fixDocsView, codedView } from "../SharedView.js";
import { ofArray, singleton } from "../fable_modules/fable-library.3.7.18/List.js";
import { Interop_reactApi as Interop_reactApi_1 } from "../fable_modules/Feliz.1.68.0/Interop.fs.js";

export function ChartJSDoughnutChart() {
    const props_9 = [["options", {
        responsive: true,
        plugins: {
            legend: {
                position: "top",
            },
            title: {
                display: true,
                text: "Chart.js Doughnut Chart",
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
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: "# of Votes",
            borderColor: ["rgba(255, 99, 132, 1)", "rgba(54, 162, 235, 1)", "rgba(255, 206, 86, 1)", "rgba(75, 192, 192, 1)", "rgba(153, 102, 255, 1)", "rgba(255, 159, 64, 1)"],
            borderWidth: 1,
            backgroundColor: ["rgba(255, 99, 132, 0.2)", "rgba(54, 162, 235, 0.2)", "rgba(255, 206, 86, 0.2)", "rgba(75, 192, 192, 0.2)", "rgba(153, 102, 255, 0.2)", "rgba(255, 159, 64, 0.2)"],
            data: new Int32Array([12, 19, 3, 5, 2, 3]),
            datalabels: {
                anchor: "end",
            },
        }],
    }]];
    return Interop_reactApi.createElement(doughnut, createObj(props_9));
}

export const ChartJSChart = (() => {
    const props = [["style", {
        height: 800,
    }]];
    const children = [createElement(ChartJSDoughnutChart, null)];
    return react.createElement("div", keyValueList(props, 1), ...children);
})();

export const code = "\n    ChartJS.doughnut [\n        doughnut.options [\n            option.responsive true\n            option.plugins [\n                plugin.legend [ legend.position Top ]\n                plugin.title [\n                    title.display true\n                    title.text \"Chart.js Doughnut Chart\"\n                ]\n                plugin.datalabels [\n                    datalabels.display true\n                    datalabels.allign Bottom\n                    datalabels.borderRadius 3\n                    datalabels.color \"red\"\n                    datalabels.backgroundColor \"green\"\n                    // datalabels.labels [\n                    //     labels.value {|color=\"blue\"|}\n                    // ]\n                    // datalabels.formatter renderCustomLabel\n                    ]\n            ]\n        ]\n        doughnut.data [\n            doughnutData.labels [|\n                \"Red\"\n                \"Blue\"\n                \"Yellow\"\n                \"Green\"\n                \"Purple\"\n                \"Orange\"\n            |]\n            doughnutData.datasets [|\n                doughnutData.dataset [\n                    doughnutDataSet.label \"# of Votes\"\n                    doughnutDataSet.borderColor [|\n                        \"rgba(255, 99, 132, 1)\"\n                        \"rgba(54, 162, 235, 1)\"\n                        \"rgba(255, 206, 86, 1)\"\n                        \"rgba(75, 192, 192, 1)\"\n                        \"rgba(153, 102, 255, 1)\"\n                        \"rgba(255, 159, 64, 1)\"\n                    |]\n                    doughnutDataSet.borderWidth 1\n                    doughnutDataSet.backgroundColor [|\n                        \"rgba(255, 99, 132, 0.2)\"\n                        \"rgba(54, 162, 235, 0.2)\"\n                        \"rgba(255, 206, 86, 0.2)\"\n                        \"rgba(75, 192, 192, 0.2)\"\n                        \"rgba(153, 102, 255, 0.2)\"\n                        \"rgba(255, 159, 64, 0.2)\"\n                    |]\n                    doughnutDataSet.data [|\n                        12\n                        19\n                        3\n                        5\n                        2\n                        3\n                    |]\n                    doughnutDataSet.datalabels [|\n                        datalabel.anchor \"end\"\n                    |]\n                ]\n            |]\n        ]\n    ]\n    ";

export const title = "Doughnut Chart";

export function DoughnutChartView() {
    let elms;
    const children_1 = ofArray([(elms = singleton(codedView(title, code, ChartJSChart)), createElement("div", {
        className: "content",
        children: Interop_reactApi_1.Children.toArray(Array.from(elms)),
    })), fixDocsView("LineChart", false)]);
    return createElement("div", {
        children: Interop_reactApi_1.Children.toArray(Array.from(children_1)),
    });
}

