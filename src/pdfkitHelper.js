
const PDFDocument = require('pdfkit');
const SVGtoPDF = require('svg-to-pdfkit');

PDFDocument.prototype.addSVG = function (svg, x, y, options) {
    return SVGtoPDF(this, svg, x, y, options), this;
};

function createDocument(settings) {
    return new PDFDocument(settings);
}

module.exports = {
    createDocument
};
